using UnityEngine;
using UnityEngine.InputSystem;

namespace VrTir.GameMenu
{
    public class GameMenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject _menu;
        [SerializeField] private InputActionProperty _showButton;

        private void Update()
        {
            if (_showButton.action.WasPressedThisFrame())
            {
                _menu.SetActive(!_menu.activeSelf);
            }
        }
    }
}
