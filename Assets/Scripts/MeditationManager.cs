using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class MeditationManager : MonoBehaviour
{
    [SerializeField] ElevenLabs elevenLabs;
    [SerializeField] private AudioSource meditationGuideAudioSrc;
    [SerializeField] AudioClip meditationGuideClip;
    [SerializeReference] LanguagesSO languagesSO;

    public static SystemLanguage systemLanguage;
    int localeID = -1;
    
    private void Start()
    {
        DetectAndSetLanguage();
        DetectDeviceModel();

        StartMeditation();       
    }

    private void StartMeditation()
    {
        string text = GetTextFromDictionary("Introduction");
        StartCoroutine(elevenLabs.GenerateAudioFromText(text, OnAudioLoaded));
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
            meditationGuideAudioSrc.clip = meditationGuideClip;
            //meditationGuideAudioSrc.Play();
        }
    }

}
