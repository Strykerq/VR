using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public GameObject Menu;
    public InputActionProperty showButton;
   
    private void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            Menu.SetActive(!Menu.activeSelf);
        }
    }
}
