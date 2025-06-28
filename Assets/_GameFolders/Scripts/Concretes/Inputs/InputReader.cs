using _GameFolders.Scripts.Abstracts.Input;
using Concretes.Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _GameFolders.Scripts.Concretes.Inputs
{
    public class InputReader : IInputReader
    {
        public float Horizontal { get; set; }

        public InputReader()
        {
            MyInputActions input = new MyInputActions();

            input.Enable();
            
            input.Player.Move.performed += HandleOnMoved;
            input.Player.Move.canceled += HandleOnMoved;
        }

        private void HandleOnMoved(InputAction.CallbackContext obj)
        {
            Horizontal = obj.ReadValue<Vector2>().x;
        }
        
    }
}