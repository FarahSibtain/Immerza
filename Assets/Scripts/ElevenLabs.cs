using UnityEngine;
using System.Globalization;
using System.Collections;
using Newtonsoft.Json;
using System;
using UnityEngine.Networking;
using System.Text;

public class ElevenLabs : MonoBehaviour
{
    [SerializeField] private string _key;
    [SerializeField] private string _apiUrl = "https://api.elevenlabs.io";
    [SerializeField] private string VoiceID;
    [SerializeField] [Range(0, 4)] int LatencyOptimization;
    [SerializeField] private AudioSource meditationGuide;

    string text = "Sitting quietly, imagine a gentle golden-white light flowing down over your head and through your body. As this golden-white light travels through every cell of your body, let go of tension and float in this sea of relaxation.";
    void Start()
    {
        DetectLanguage();

        StartCoroutine(GenerateAudioFromText(text));
    }

    void DetectLanguage()
    {
        // Get the system language
        SystemLanguage systemLanguage = Application.systemLanguage;

        // Convert to a more readable format
        string languageName = CultureInfo.CurrentCulture.EnglishName;

        Debug.Log("Detected VR Headset Language: " + systemLanguage.ToString());
        Debug.Log("Detected Culture Info Language: " + languageName);
    }

    IEnumerator GenerateAudioFromText(string message)
    {        
        var postData = new TextToSpeechRequest { text = message };
        var json = JsonConvert.SerializeObject(postData);
        var url = $"{_apiUrl}/v1/text-to-speech/{VoiceID}?optimize_streaming_latency={LatencyOptimization}";
        using (var request = UnityWebRequest.Post(url, string.Empty, "application/json"))
        using (var uH = new UploadHandlerRaw(Encoding.ASCII.GetBytes(json)))
        {
            request.uploadHandler = uH;
            DownloadHandlerAudioClip downloadHandler = new DownloadHandlerAudioClip(url, AudioType.MPEG);
            downloadHandler.streamAudio = true;
            request.downloadHandler = downloadHandler;            
            request.SetRequestHeader("xi-api-key", _key);
            request.SetRequestHeader("Accept", "audio/mpeg");
            //Debug.Log("Sending text message: " + message);
            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError($"Error downloading audio stream from:{url} : {request.error}");
            }
            else
            {
                // Handle the response
                AudioClip audioClip = downloadHandler.audioClip; // DownloadHandlerAudioClip.GetContent(request);            
                if (audioClip == null)
                {
                    Debug.Log("Couldn't process audio stream.");
                    yield break;
                }
                meditationGuide.clip = audioClip;
                meditationGuide.Play();                
            }

            request.disposeUploadHandlerOnDispose = true;
            request.disposeDownloadHandlerOnDispose = true;
            
            request.Dispose();
        }
    }


    [Serializable]
    public class TextToSpeechRequest
    {
        public string text;
        public string model_id = "eleven_multilingual_v2";
        public VoiceSettings voice_settings = new VoiceSettings();
    }

    [Serializable]
    public class VoiceSettings
    {
        public float stability = 0.5f;
        public float similarity_boost = 0.75f;
        public float style = 0;
        public bool use_speaker_boost = true;
    }
}
