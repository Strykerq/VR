using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       text.text = ("Target speed : " + slider.value);
    }

    public void OnSliderValueChanged()
    {
        text.text = slider.value.ToString();
    }
}
