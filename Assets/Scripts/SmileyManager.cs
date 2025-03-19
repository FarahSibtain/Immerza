using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using XLua.CSObjectWrap;

public class SmileyManager : MonoBehaviour
{
    [SerializeField] float startAngle = 95f;
    [SerializeField] float endAngle = 90f;
    [SerializeField] float speed = 1f;
    [SerializeField] float maxIntensityForSmiley = 2.5f;    
    [SerializeField] Material smileyMaterial;  // Assign your material in the Inspector
    [SerializeField] float maxIntensityForSmileyFrame = 2.5f;
    [SerializeField] Material smileyFrameMaterial;  // Assign your material in the Inspector
    [SerializeField] Texture smallSmile;
    [SerializeField] Texture bigSmile;
    [SerializeField] float duration = 5f;      // Time to reach full intensity
    Material origSmileyMaterial;
    Material origSmileyFrameMaterial;
    public static Action WindowHoverEnter;
    public static Action WindowHoverExit;

    private float elapsedTime = 0f;
    private Color baseColor;  // Store the base emission color
    float desiredAngle = 0f;

    private void Start()
    {
        // transform.localRotation = Quaternion.Euler(0, startAngle, -180);
        desiredAngle = startAngle;
        elapsedTime = duration;

        // Get the base color (assumes the material has an emission color)
        baseColor = smileyMaterial.GetColor("_EmissionColor");
        origSmileyMaterial = GetComponent<Renderer>().material;
        origSmileyFrameMaterial = GetComponentInChildren<Renderer>().material;
    }

    private void Update()
    {
        float currentAngle = transform.localEulerAngles.y;
        if (Mathf.Abs(desiredAngle - currentAngle) > 0.01f)
        {
            // Interpolate the angle
            currentAngle = Mathf.LerpAngle(currentAngle, desiredAngle, speed * Time.deltaTime);

            // Apply the interpolated angle to the game object's rotation
            transform.localRotation = Quaternion.Euler(0, currentAngle, -180);
        }

        if (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;

            //For Smiley
            float intensity = Mathf.Lerp(1, maxIntensityForSmiley, elapsedTime / duration);  // Interpolate from 0 to 1

            // Apply the new intensity to the material's emission
            smileyMaterial.SetColor("_EmissionColor", baseColor * intensity);

            //For Smiley Frame
            //Emission
            intensity = Mathf.Lerp(1, maxIntensityForSmileyFrame, elapsedTime / duration);  // Interpolate from 0 to 1
            // Apply the new intensity to the material's emission
            smileyFrameMaterial.SetColor("_EmissionColor", baseColor * intensity);
            //Alpha
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / duration);
            // Apply the new color with updated alpha
            smileyFrameMaterial.color = new Color(smileyFrameMaterial.color.r, smileyFrameMaterial.color.g, smileyFrameMaterial.color.b, alpha);
        }
    }
    public void OnSmileyHoverEnter(HoverEnterEventArgs hoverEnterEventArgs)
    {
        desiredAngle = endAngle;
        elapsedTime = 0;        
        //smileyMaterial.SetTexture("_EmissionMap", bigSmile);

        //Set smiley material
        Renderer renderer = GetComponent<Renderer>();
        renderer.material = smileyMaterial;

        Renderer renderer2 = transform.GetChild(0).GetComponent<Renderer>();
        renderer2.material = smileyFrameMaterial;

        WindowHoverEnter?.Invoke();
    }
    public void OnSmileyHoverExit(HoverExitEventArgs hoverExitEventArgs)
    {
        desiredAngle = startAngle;
        elapsedTime = duration;
        smileyMaterial.SetColor("_EmissionColor", baseColor);
        smileyFrameMaterial.SetColor("_EmissionColor", baseColor);
        //smileyMaterial.SetTexture("_EmissionMap", smallSmile);
        smileyFrameMaterial.color = new Color(smileyFrameMaterial.color.r, smileyFrameMaterial.color.g, smileyFrameMaterial.color.b, 1);
        //Set smiley material back to original
        Renderer renderer = GetComponent<Renderer>();
        renderer.material = origSmileyMaterial;

        renderer = transform.GetChild(0).GetComponent<Renderer>();
        renderer.material = origSmileyFrameMaterial;

        WindowHoverExit?.Invoke();
    }
    private void OnApplicationQuit()
    {
        smileyMaterial.SetColor("_EmissionColor", baseColor);
        smileyFrameMaterial.SetColor("_EmissionColor", baseColor);
        smileyFrameMaterial.color = new Color(smileyFrameMaterial.color.r, smileyFrameMaterial.color.g, smileyFrameMaterial.color.b, 1);
        //Set smiley material back to original
        Renderer renderer = GetComponent<Renderer>();
        renderer.material = origSmileyMaterial;

        renderer = transform.GetChild(0).GetComponent<Renderer>();
        renderer.material = origSmileyFrameMaterial;
    }
}
