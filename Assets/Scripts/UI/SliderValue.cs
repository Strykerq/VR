using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRTir.TargetsMovement;

namespace VRTir.SliderUI
{
    public class SliderValue : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private TextMeshProUGUI _text;
        private MovementTargets _movementTargets;

        private void Start ()
        {
            _movementTargets = new MovementTargets();
        }

        private void Update()
        {
            _text.text = ("Target speed : " + _slider.value);
            _movementTargets.Speed = _slider.value;
        }

        public void OnSliderValueChanged()
        {
            _text.text = _slider.value.ToString();
        }
    }
}
