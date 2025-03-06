using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class MeditationStatesManager : MonoBehaviour
{
    [SerializeField] ElevenLabs elevenLabs;
    [SerializeField] private AudioSource meditationGuideAudioSrc;
    [SerializeReference] LanguagesSO languagesSO;
    string selectedWindow;
    //[SerializeField] AudioClip meditationGuideClip;

    public static SystemLanguage systemLanguage;
    int localeID = -1;    
    ESTATE currentState;
    public static Action AllowWindowsInteractible;
    public static Action StopWindowsInteractible;

    WaitForSeconds waitFor2Seconds;
    Dictionary<string, AudioClip> generatedAudios;

    private void SubcribeToWindowEvents()
    {
        WindowInteractionManager.WindowSelected += WindowSelected;
        WindowInteractionManager.WindowExited += WindowExited;
    }

    private void OnDisable()
    {
        WindowInteractionManager.WindowSelected -= WindowSelected;
        WindowInteractionManager.WindowExited -= WindowExited;
    }

    enum ESTATE
    {
        INTRODUCTORY,
        GETSTARTED,
        MEDITATE
    }
    
    private void Start()
    {
        waitFor2Seconds = new WaitForSeconds(2);
        generatedAudios = new Dictionary<string, AudioClip>();
        DetectAndSetLanguage();
        DetectDeviceModel();

        ChangeState(ESTATE.INTRODUCTORY);
    }

    private void ChangeState(ESTATE newState)
    {
        currentState = newState;
        Debug.Log("State changed to " + currentState.ToString());
        ProcessState();
    }

    private void ProcessState()
    {
        switch(currentState)
        {
            case ESTATE.INTRODUCTORY:
                StartCoroutine(ProcessIntroductoryState());
                break;

            case ESTATE.GETSTARTED:
                StartCoroutine(ProcessGetStartedState());
                break;

            case ESTATE.MEDITATE:
                ProcessMeditateState();
                break;
        }
    }    

    private IEnumerator ProcessIntroductoryState()
    {
        string text = GetTextFromDictionary("Introduction");
        Debug.Log("text: " + text);

        bool isAudioLoaded = false;
        StartCoroutine(elevenLabs.GenerateAudioFromText(text, (clip) =>
        {
            OnAudioLoaded(clip);
            isAudioLoaded = true;
        }));

        yield return new WaitUntil(() => isAudioLoaded && !meditationGuideAudioSrc.isPlaying);

        //Wait for 2 seconds before going to the next stage
        yield return waitFor2Seconds;

        ChangeState(ESTATE.GETSTARTED);
    }

    private IEnumerator ProcessGetStartedState()
    {
        string text = GetTextFromDictionary("GetStarted");
        Debug.Log("text: " + text);
        bool isAudioLoaded = false;
        StartCoroutine(elevenLabs.GenerateAudioFromText(text, (clip) =>
        {
            OnAudioLoaded(clip);
            isAudioLoaded = true;
        }));

        //Wait for 2 seconds for the audio to begin
        yield return waitFor2Seconds;
        AllowWindowsInteractible?.Invoke();

        yield return new WaitUntil(() => isAudioLoaded && !meditationGuideAudioSrc.isPlaying);

        //Wait for 2 seconds before going to the next stage
        yield return waitFor2Seconds;

        ChangeState(ESTATE.MEDITATE);
    }

    private void ProcessMeditateState()
    {
        SubcribeToWindowEvents();
        ProcessMeditation();
    }

    private void ProcessMeditation()
    {
        meditationGuideAudioSrc.mute = false;

        switch (selectedWindow)
        {
            case "Yourself":
                ProcessYourselfStage();
                break;
            case "GoodFriend":
                ProcessFriendStage();
                break;
            case "NeutralPerson":
                ProcessNeutralStage();
                break;
            case "DifficultPerson":
                ProcessDifficultStage();
                break;
            case "AllSentientBeings":
                ProcessSentientStage();
                break;
        }
    }

    private void ProcessSentientStage()
    {
        string text1 = GetTextFromDictionary("AllSentientBeings");
        string text2 = GetTextFromDictionary("Other");
        string fullText = text1 + text2;
        Debug.Log("text: " + fullText);
        StartCoroutine(ProcessSentences(fullText));
    }

    private void ProcessDifficultStage()
    {
        string text1 = GetTextFromDictionary("DifficultPerson");
        string text2 = GetTextFromDictionary("Other");
        string fullText = text1 + text2;
        Debug.Log("text: " + fullText);
        StartCoroutine(ProcessSentences(fullText));
    }

    private void ProcessNeutralStage()
    {
        string text1 = GetTextFromDictionary("NeutralPerson");
        string text2 = GetTextFromDictionary("Other");
        string fullText = text1 + text2;
        Debug.Log("text: " + fullText);
        StartCoroutine(ProcessSentences(fullText));
    }

    private void ProcessFriendStage()
    {
        string text1 = GetTextFromDictionary("GoodFriend");
        string text2 = GetTextFromDictionary("Other");
        string fullText = text1 + text2;
        Debug.Log("text: " + fullText);
        StartCoroutine(ProcessSentences(fullText));
    }

    private void ProcessYourselfStage()
    {
        string fullText = GetTextFromDictionary("Yourself");
        Debug.Log("text: " + fullText);
        StartCoroutine(ProcessSentences(fullText));        

        //Activate the loving-kindness energy art flowing towards the windows
        //TODO
    }

    private IEnumerator ProcessSentences(string fullText)
    {
        string[] sentences = fullText.Split(new char[] { '.', '!', '?' }); // Split sentences
        List<AudioClip> audioClips = new List<AudioClip>();

        foreach (string sentence in sentences)
        {
            if (string.IsNullOrWhiteSpace(sentence)) continue; // Skip empty parts
            
            string trimmedSentence = sentence.Trim() + "."; // Ensure punctuation
            AudioClip clip;
            if (generatedAudios.TryGetValue(trimmedSentence, out clip))
            {
                audioClips.Add(clip);
            }
            else
            {
                Debug.Log("Generating audio for: " + trimmedSentence);
                // Generate audio from ElevenLabs
                yield return StartCoroutine(elevenLabs.GenerateAudioFromText(trimmedSentence, (AudioClip clip) =>
                {
                    if (clip != null) audioClips.Add(clip);
                    generatedAudios[trimmedSentence] = clip;
                }));
            }                        
        }

        // Play all audio clips in sequence
        StartCoroutine(PlayAudioSequentially(audioClips));
    }

    private IEnumerator PlayAudioSequentially(List<AudioClip> clips)
    {
        //Play the clips in a loop
        int index = 0;
        while(true)
        {
            //If user breaks the gaze with the window then stop meditation audio
            if (string.IsNullOrEmpty(selectedWindow))
            {
                StopMeditationAudio();
                break;
            }
            else
            {
                meditationGuideAudioSrc.clip = clips[index];
                meditationGuideAudioSrc.Play();
                yield return new WaitForSeconds(clips[index].length + 1f); // Wait for clip + pause
                index++;

                if (index >= clips.Count)
                    index = 0;
            }            
        }
    }

    string GetTextFromDictionary(string key)
    {
        string text = null;
        switch(localeID)
        {
            case 0: //English
                text = languagesSO.GetValue(key).Item1;
                break;

            case 1: //German
                text = languagesSO.GetValue(key).Item2;
                break;
        }
        return text;
    }

    void DetectAndSetLanguage()
    {
        // Get the system language
        SystemLanguage systemLanguage = Application.systemLanguage;        
        Debug.Log("Detected VR Headset Language: " + systemLanguage.ToString());
        
        switch(systemLanguage.ToString().ToLower())
        {
            case "english":
                localeID = 0;                
                break;

            case "german":
                localeID = 1;                
                break;
        }
        SetLocale(localeID);
    }

    IEnumerator SetLocale(int locateID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[locateID];
    }

    void DetectDeviceModel()
    {
        string deviceModel = SystemInfo.deviceModel;
        Debug.Log("Device Model: " + deviceModel);

        if (deviceModel.Contains("Quest 2"))
        {
            Debug.Log("Running on Quest 2");
        }
        else if (deviceModel.Contains("Quest 3"))
        {
            Debug.Log("Running on Quest 3");
        }
    }

    void OnAudioLoaded(AudioClip clip)
    {
        if (clip != null)
        {
            Debug.Log("Audio loaded successfully!");
            meditationGuideAudioSrc.clip = clip;
            meditationGuideAudioSrc.Play();
        }
        else
        {
            Debug.LogError("Failed to load audio.");
            //meditationGuideAudioSrc.clip = meditationGuideClip;
            //meditationGuideAudioSrc.Play();
        }
    }

    private void WindowSelected(string window)
    {
        selectedWindow = window;
        ProcessMeditation();
    }
    private void WindowExited()
    {
        selectedWindow = string.Empty;        
    }

    private void StopMeditationAudio()
    {
        meditationGuideAudioSrc.mute = true;
        meditationGuideAudioSrc.clip = null;
    }
}
