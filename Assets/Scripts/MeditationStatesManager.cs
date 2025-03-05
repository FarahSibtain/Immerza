using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class MeditationStatesManager : MonoBehaviour
{
    [SerializeField] ElevenLabs elevenLabs;
    [SerializeField] private AudioSource meditationGuideAudioSrc;
    [SerializeReference] LanguagesSO languagesSO;
    Transform selectedWindow;
    //[SerializeField] AudioClip meditationGuideClip;

    public static SystemLanguage systemLanguage;
    int localeID = -1;

    ESTATE currentState;
    public static Action AllowWindowsInteractible;
    public static Action StopWindowsInteractible;

    private void OnEnable()
    {
        GazeInteractionManager.WindowSelected += WindowSelected;
    }

    private void OnDisable()
    {
        GazeInteractionManager.WindowSelected -= WindowSelected;
    }

    enum ESTATE
    {
        INTRODUCTORY,
        GETSTARTED,
        MEDITATE
    }
    
    private void Start()
    {
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
                StartCoroutine(ProcessMeditateState());
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
        yield return new WaitForSeconds(2);

        ChangeState(ESTATE.GETSTARTED);
    }

    private IEnumerator ProcessGetStartedState()
    {
        string text = GetTextFromDictionary("GetStarted");
        Debug.Log("text: " + text);
        StartCoroutine(elevenLabs.GenerateAudioFromText(text, OnAudioLoaded));

        //Wait for 2 seconds for the audio to begin
        yield return new WaitForSeconds(2);

        AllowWindowsInteractible?.Invoke();
    }

    private IEnumerator ProcessMeditateState()
    {
        StopWindowsInteractible?.Invoke();

        //switch(selectedWindow.parent.name)
        //{
        //    case "Yourself":
        //        ProcessYourselfStage();
        //        break;
        //    case "GoodFriend":
        //        break;
        //    case "NeutralPerson":
        //        break;
        //    case "DifficultPerson":
        //        break;
        //    case "AllSentientBeings":
        //        ProcessYourselfStage();
        //        break;
        //}
        yield return null;
    }

    private void ProcessYourselfStage()
    {
        string text = GetTextFromDictionary("Yourself");
        Debug.Log("text: " + text);
        StartCoroutine(elevenLabs.GenerateAudioFromText(text, OnAudioLoaded));

        //play the meditation audio in loop
        meditationGuideAudioSrc.loop = true;

        //Activate the loving-kindness energy art flowing towards the windows
        //TODO
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

    private void WindowSelected(Transform window)
    {
        selectedWindow = window;
        ChangeState(ESTATE.MEDITATE);        
    }
}
