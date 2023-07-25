using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    public float Fps;
    public TextMeshProUGUI fpsText;

    private void Start()
    {
        InvokeRepeating("GetFPS", 1, 1);
    }

    public void GetFPS()
    {
        Fps = (int)(1f / Time.unscaledDeltaTime);
        fpsText.text = Fps + " fps";
    }
}
