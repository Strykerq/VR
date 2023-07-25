using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider Slider;
    public TextMeshProUGUI Text;
  
    private void Update()
    {
       Text.text = ("Target speed : " + Slider.value);
    }

    public void OnSliderValueChanged()
    {
        Text.text = Slider.value.ToString();
    }
}
