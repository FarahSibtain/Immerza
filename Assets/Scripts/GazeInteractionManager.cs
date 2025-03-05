using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GazeInteractionManager : MonoBehaviour
{
    public static Action<Transform> WindowSelected;
    public void OnGazeHovered(HoverEnterEventArgs args)
    {
        Debug.Log("Gaze Interactor is hovering over: " + args.interactableObject.transform.parent.name);
        WindowSelected?.Invoke(args.interactableObject.transform);
    }

    public void OnGazeHoverExited(HoverExitEventArgs args)
    {
        Debug.Log("Gaze Interactor exitted hovering over: " + args.interactableObject.transform.name);
    }
}
