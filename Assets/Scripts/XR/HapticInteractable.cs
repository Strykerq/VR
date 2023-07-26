using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace VRTir.Haptic
{
    public class HapticInteractable : MonoBehaviour
    {
        [Range(0, 1)]
        [SerializeField] private float _intensity;
        [SerializeField] private float _duration;
        private void Start()
        {
            XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
            interactable.activated.AddListener(TriggerHaptic);
        }

        public void TriggerHaptic(BaseInteractionEventArgs eventargs)
        {
            if (eventargs.interactableObject is XRBaseControllerInteractor controllerInteractor)
            {
                TriggerHaptic(controllerInteractor.xrController);
            }
        }
        public void TriggerHaptic(XRBaseController controller)
        {
            if (_intensity > 0)
            {
                controller.SendHapticImpulse(_intensity, _duration);
            }
        }
    }
}
