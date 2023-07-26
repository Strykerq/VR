using UnityEngine;
using UnityEngine.InputSystem;

namespace VRTir.AnimateHand
{
    public class AnimateHandOnInput : MonoBehaviour
    {
        [SerializeField] private InputActionProperty _pinchAnimationAction;
        [SerializeField] private InputActionProperty _gripAnimationAction;
        [SerializeField] private Animator _handAnimator;

        private void Update()
        {
            float triggervalue = _pinchAnimationAction.action.ReadValue<float>();
            _handAnimator.SetFloat("Trigger", triggervalue);

            float gripvalue = _gripAnimationAction.action.ReadValue<float>();
            _handAnimator.SetFloat("Grip", gripvalue);
        }
    }
}
