using System.Collections;
using System.Collections.Generic;
//using System.Drawing;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color color = Color.red;
    public Color startColor;
    MeshRenderer render;

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (render != null)
        {
            render.material.color = color;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        render.material.color = startColor;
    }
}
