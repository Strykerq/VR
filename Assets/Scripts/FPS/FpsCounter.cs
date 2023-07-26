using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace VRTir.FPS
{
    public class FpsCounter : MonoBehaviour
    {
        private float _fps;
        [SerializeField] private TextMeshProUGUI fpsText;

        private void Start()
        {
            InvokeRepeating("GetFPS", 1, 1);
        }

        public void GetFPS()
        {
            _fps = (int)(1f / Time.unscaledDeltaTime);
            fpsText.text = _fps + " fps";
        }
    }
}
