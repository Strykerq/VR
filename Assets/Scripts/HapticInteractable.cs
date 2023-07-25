using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class HapticInteractable : MonoBehaviour
{
    [Range(0, 1)]
    public float Intensity;
    public float Duration;
    private void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.activated.AddListener(TriggerHaptic);
    }

    public void TriggerHaptic(BaseInteractionEventArgs eventargs)
    {
        if(eventargs.interactableObject is XRBaseControllerInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor.xrController);
        }
        
    }

    public void TriggerHaptic(XRBaseController controller)
    {
        if(Intensity > 0)
        {
            controller.SendHapticImpulse(Intensity,Duration);
        }
    }
    
}
