using UnityEngine;
using UnityEngine.UI;

namespace VRTir.TargetsMovement
{
    public class MovementTargets : MonoBehaviour
    {
        [HideInInspector] public float Speed = 2f;
        private bool _isMoving = true;
        [SerializeField] private Slider _speedSlider;

        public void Update()
        {
            if (_isMoving)
            {
                transform.Translate(Vector2.right * Speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.left * Speed * Time.deltaTime);
            }

            if (transform.position.x > 5.5f)
            {
                _isMoving = false;
            }
            else if (transform.position.x < -3.7f)
            {
                _isMoving = true;
            }
        }
    }
}
