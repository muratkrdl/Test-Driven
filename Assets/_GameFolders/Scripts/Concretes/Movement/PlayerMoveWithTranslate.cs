using _GameFolders.Scripts.Abstracts.Interfaces;
using UnityEngine;

namespace _GameFolders.Scripts.Concretes.Movement
{
    public class PlayerMoveWithTranslate : IMover
    {
        private readonly IPlayerController _playerController;
        private readonly Transform _transform;
        
        private float _moveSpeed = 1f;
        private float _horizontalInput = 1f;
        
        public PlayerMoveWithTranslate(IPlayerController playerController)
        {
            _playerController = playerController;
            _transform = playerController.transform;
        }
        
        public void Tick()
        {
            _horizontalInput = _playerController.InputReader.Horizontal;
        }

        public void FixedTick()
        {
            _transform.Translate(Vector2.right * _horizontalInput * (_moveSpeed * Time.deltaTime));
        }
    }
}