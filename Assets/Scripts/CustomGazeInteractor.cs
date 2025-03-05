using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class CustomGazeInteractor : MonoBehaviour
{
    private XRRayInteractor rayInteractor;
    private float gazeDuration = 2f; // Adjust for desired gaze time
    private float gazeTimer = 0f;
    private IXRInteractable lastTarget;

    void Start()
    {
        rayInteractor = GetComponent<XRRayInteractor>();
    }

    void Update()
    {
        if (rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit))
        {
            IXRInteractable target = hit.collider.GetComponent<IXRInteractable>();

            if (target != null)
            {
                if (target != lastTarget)
                {
                    gazeTimer = 0f; // Reset when looking at a new object
                    lastTarget = target;
                }

                gazeTimer += Time.deltaTime;
                if (gazeTimer >= gazeDuration)
                {
                    InteractWithTarget(target);
                    gazeTimer = 0f; // Reset timer after interaction
                }
            }
            else
            {
                gazeTimer = 0f; // Reset when not hitting an interactable
                lastTarget = null;
            }
        }
    }

    private void InteractWithTarget(IXRInteractable target)
    {
        // Trigger any interaction logic (e.g., button click, object selection)
        Debug.Log("Gaze Interacted with " + target.transform.name);
    }
}
