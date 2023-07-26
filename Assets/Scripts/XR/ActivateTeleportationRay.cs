using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

namespace VRTir.TeleportLogic
{
    public class ActivateTeleportationRay : MonoBehaviour
    {
        [SerializeField] private GameObject _leftTeleportation;
        [SerializeField] private GameObject _rightTeleportation;

        [SerializeField] private InputActionProperty _leftActivate;
        [SerializeField] private InputActionProperty _rightActivate;

        [SerializeField] private InputActionProperty _leftCancel;
        [SerializeField] private InputActionProperty _rightCancel;


        [SerializeField] private XRRayInteractor _leftRay;
        [SerializeField] private XRRayInteractor _rightRay;


        public void Update()
        {
            bool isLeftRayHovering = _leftRay.TryGetHitInfo(out Vector3 leftpos, out Vector3 leftnormal, out int leftnumber, out bool leftValid);

            _leftTeleportation.SetActive(!isLeftRayHovering && _leftCancel.action.ReadValue<float>() == 0 && _leftActivate.action.ReadValue<float>() > 0.1f);

            bool isRightRayHovering = _rightRay.TryGetHitInfo(out Vector3 rightpos, out Vector3 normal, out int rightnumber, out bool rightValid);

            _rightTeleportation.SetActive(!isRightRayHovering && _rightCancel.action.ReadValue<float>() == 0 && _rightActivate.action.ReadValue<float>() > 0.1f);
        }
    }

}
