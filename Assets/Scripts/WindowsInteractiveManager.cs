using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class WindowsInteractiveManager : MonoBehaviour
{
    [SerializeField] XRSimpleInteractable window1; 
    [SerializeField] XRSimpleInteractable window2; 
    [SerializeField] XRSimpleInteractable window3; 
    [SerializeField] XRSimpleInteractable window4; 
    [SerializeField] XRSimpleInteractable window5;

    private void OnEnable()
    {
        MeditationStatesManager.AllowWindowsInteractible += AllowWindowsInteractible;
        MeditationStatesManager.StopWindowsInteractible += StopWindowsInteractible;

        StopWindowsInteractible();
    }

    private void OnDisable()
    {
        MeditationStatesManager.AllowWindowsInteractible -= AllowWindowsInteractible;
        MeditationStatesManager.StopWindowsInteractible -= StopWindowsInteractible;
    }

    private void AllowWindowsInteractible()
    {
        SetWindowsInteractible(true);
    }

    private void StopWindowsInteractible()
    {
        SetWindowsInteractible(false);
    }

    private void SetWindowsInteractible(bool flag)
    {
        window1.enabled = flag;
        window2.enabled = flag;
        window3.enabled = flag;
        window4.enabled = flag;
        window5.enabled = flag;
    }
}
