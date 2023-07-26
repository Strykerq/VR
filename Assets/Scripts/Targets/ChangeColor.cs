using UnityEngine;

namespace VRTir.Target
{
    public class ChangeColor : MonoBehaviour
    {
        public Color Color = Color.red;
        [SerializeField] private Color _startColor;
        MeshRenderer render;
        private void Start()
        {
            render = GetComponent<MeshRenderer>();
        }
        public void OnCollisionEnter(Collision collision)
        {
            if (render != null)
            {
                render.material.color = Color;
            }
        }
        public void OnCollisionExit(Collision collision)
        {
            render.material.color = _startColor;
        }
    }
}
