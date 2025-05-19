using _GameFolders.Scripts.Abstracts.Input;
using _GameFolders.Scripts.Abstracts.Interfaces;
using _GameFolders.Scripts.Concretes.Inputs;
using _GameFolders.Scripts.Concretes.Movement;
using UnityEngine;

namespace _GameFolders.Scripts.Concretes.Controller
{
    public class PlayerController : MonoBehaviour, IPlayerController
    {
        private IMover _mover;
        public IInputReader InputReader { get; set; }

        private void Awake()
        {
            InputReader = new InputReader();
            _mover = new PlayerMoveWithTranslate(this);
        }

        private void Update()
        {
            _mover.Tick();
        }
        
        private void FixedUpdate()
        {
            _mover.FixedTick();
        }
    }
}
