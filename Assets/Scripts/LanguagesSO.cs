using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LanguagesSO", menuName = "ScriptableObjects/LanguagesSO")]
public class LanguagesSO : ScriptableObject, ISerializationCallbackReceiver
{
    [SerializeField] private List<string> keys = new List<string>();
    [SerializeField] private List<string> English = new List<string>(); // First value
    [SerializeField] private List<string> German = new List<string>(); // Second value

    private Dictionary<string, (string, string)> dictionary = new Dictionary<string, (string, string)>();

    public void OnAfterDeserialize()
    {
        dictionary.Clear();
        for (int i = 0; i < keys.Count; i++)
        {
            dictionary[keys[i]] = (English[i], German[i]);
        }
    }

    public void OnBeforeSerialize()
    {
        keys.Clear();
        English.Clear();
        German.Clear();
        foreach (var pair in dictionary)
        {
            keys.Add(pair.Key);
            English.Add(pair.Value.Item1);
            German.Add(pair.Value.Item2);
        }
    }

    public (string, string) GetValue(string key)
    {
        return dictionary.TryGetValue(key, out var value) ? value : ("", "");
    }

    public void SetValue(string key, string value1, string value2)
    {
        dictionary[key] = (value1, value2);
    }
}

