using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LanguagesSO))]
public class MyScriptableObjectEditor : Editor
{
    public override void OnInspectorGUI()
    {
        LanguagesSO scriptableObject = (LanguagesSO)target;

        // Force Unity to update the scriptable object properly
        if (GUILayout.Button("Fix List Sizes"))
        {
            scriptableObject.OnBeforeSerialize();
            EditorUtility.SetDirty(scriptableObject);
        }

        DrawDefaultInspector();
    }
}

