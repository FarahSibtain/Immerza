using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class WindowInteractionManager : MonoBehaviour
{
    [SerializeField] MeshRenderer frameOuter;
    [SerializeField] MeshRenderer frameInner;

    [SerializeField] Material frameOuterDefaultMat;
    [SerializeField] Material frameInnerDefaultMat;

    [SerializeField] Material frameOuterSelectMat;
    [SerializeField] Material frameInnerSelectMat;

    [SerializeField] GameObject progress;

    XRSimpleInteractable interactable;
    public static Action<string> WindowSelected;
    public static Action WindowExited;

    //[SerializeField] Animator glowFrame;
    //[SerializeField] Animator defaultFrame;

    private void OnEnable()
    {
        MeditationStatesManager.AllowWindowsInteractible += AllowWindowsInteractible;
        progress.SetActive(false);
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.enabled = false;
        //glowFrame.enabled = false;
        //defaultFrame.enabled = false;
    }

    private void OnDisable()
    {
        MeditationStatesManager.AllowWindowsInteractible -= AllowWindowsInteractible;        
    }

    private void AllowWindowsInteractible()
    {
        interactable.enabled = true;        
    }

    public void OnWindowHoverEnter(HoverEnterEventArgs hoverEnterEventArgs)
    {
        string windowName = hoverEnterEventArgs.interactableObject.transform.parent.parent.name;
        Debug.Log("Hover enter event called for window " + windowName);
        frameOuter.material = frameOuterSelectMat;
        frameInner.material = frameInnerSelectMat;

        //Start meditation progress 
        progress.SetActive(true);
        WindowSelected?.Invoke(windowName);
        //glowFrame.enabled = true;
        //defaultFrame.enabled = false;
    }

    public void OnWindowHoverExit(HoverExitEventArgs hoverExitEventArgs)
    {
        string windowName = hoverExitEventArgs.interactableObject.transform.parent.parent.name;
        Debug.Log("Hover exit event called for window " + windowName);
        frameOuter.material = frameOuterDefaultMat;
        frameInner.material = frameInnerDefaultMat;

        //Stop meditation progress 
        progress.SetActive(false);
        WindowExited?.Invoke();

        //glowFrame.enabled = false;
        //defaultFrame.enabled = true;
    }
}
