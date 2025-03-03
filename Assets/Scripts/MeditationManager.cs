using System.Globalization;
using UnityEngine;

public class MeditationManager : MonoBehaviour
{
    [SerializeField] ElevenLabs elevenLabs;
    [SerializeField] private AudioSource meditationGuideAudioSrc;
    [SerializeField] AudioClip meditationGuideClip;

    public static SystemLanguage systemLanguage;

    string text = "Sitting quietly, imagine a gentle golden-white light flowing down over your head and through your body. As this golden-white light travels through every cell of your body, let go of tension and float in this sea of relaxation.";

    private void Start()
    {
        DetectLanguage();
        DetectDeviceModel();

        StartCoroutine(elevenLabs.GenerateAudioFromText(text, OnAudioLoaded));
    }
    void DetectLanguage()
    {
        // Get the system language
        SystemLanguage systemLanguage = Application.systemLanguage;        
        Debug.Log("Detected VR Headset Language: " + systemLanguage.ToString());        
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
            //meditationGuideAudioSrc.Play();
        }
        else
        {
            Debug.LogError("Failed to load audio.");
            meditationGuideAudioSrc.clip = meditationGuideClip;
            //meditationGuideAudioSrc.Play();
        }
    }

}
