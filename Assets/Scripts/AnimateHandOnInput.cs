using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;

    private void Update()
    {
        float triggervalue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggervalue);

        float gripvalue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripvalue);        
    }
}
