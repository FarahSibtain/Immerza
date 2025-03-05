using UnityEngine;
using TMPro;

[ExecuteInEditMode] // Runs in Editor Mode too
public class WarpTextIntoU : MonoBehaviour
{
    public float curveStrength = 5f; // Controls U shape depth
    public bool inverted = false; // If true, inverts the U shape

    private TMP_Text textMeshPro;

    void Awake()
    {
        textMeshPro = GetComponent<TMP_Text>();
        WarpText();
    }

    void Update()
    {
        if (!Application.isPlaying) // Update in Editor
        {
            WarpText();
        }
    }

    void WarpText()
    {
        if (textMeshPro == null)
            return;

        textMeshPro.ForceMeshUpdate();
        TMP_TextInfo textInfo = textMeshPro.textInfo;
        int characterCount = textInfo.characterCount;

        if (characterCount == 0)
            return;

        float midPoint = textMeshPro.bounds.extents.x; // Center of the text

        for (int i = 0; i < characterCount; i++)
        {
            TMP_CharacterInfo charInfo = textInfo.characterInfo[i];

            if (!charInfo.isVisible)
                continue;

            int vertexIndex = charInfo.vertexIndex;
            int materialIndex = charInfo.materialReferenceIndex;
            Vector3[] vertices = textInfo.meshInfo[materialIndex].vertices;

            // Find the character's x position relative to the center
            float xPosition = (vertices[vertexIndex].x + vertices[vertexIndex + 2].x) / 2f;
            float normalizedX = (xPosition - midPoint) / midPoint; // Normalize between -1 and 1

            // Calculate curve effect (U-shape)
            float curveOffset = curveStrength * (1 - normalizedX * normalizedX);

            if (inverted)
                curveOffset = -curveOffset; // Invert for an inverted U

            // Apply offset to all 4 vertices of the character
            for (int j = 0; j < 4; j++)
            {
                vertices[vertexIndex + j].y += curveOffset;
            }
        }

        textMeshPro.UpdateVertexData();
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        WarpText();
    }
#endif
}
