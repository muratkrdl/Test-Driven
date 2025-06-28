using System.Collections;
using _GameFolders.Scripts.Abstracts.Input;
using _GameFolders.Scripts.Abstracts.Interfaces;
using _GameFolders.Scripts.Concretes.Controller;
using JetBrains.Annotations;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace _GameFolders.Scripts.Tests.PlayModeTest
{
    public class player_movement
    {
        private IPlayerController _playerController;
        
        private IEnumerator LoadPlayerMoveTestScene()
        {
            yield return SceneManager.LoadSceneAsync("MoveTest");
        }

        [UnitySetUp]
        IEnumerator Setup()
        {
            yield return LoadPlayerMoveTestScene();
            _playerController = GameObject.FindAnyObjectByType<PlayerController>();
            _playerController.InputReader = Substitute.For<IInputReader>();
        }
        
        [UnityTest]
        [TestCase(1f, ExpectedResult = (IEnumerator)null)]
        [TestCase(-1f, ExpectedResult = (IEnumerator)null)]
        public IEnumerator Player_move_left_right_equal_not_star_pos(float input)
        {
            // Arrange
            // yield return LoadPlayerMoveTestScene();
            
            Vector3 startPos = _playerController.transform.position;
            
            //Act
            _playerController.InputReader.Horizontal.Returns(input);
            
            yield return new WaitForSeconds(3f);
            //Assert
            Assert.AreNotEqual(startPos, _playerController.transform.position);
        }

        [UnityTest]
        public IEnumerator Player_move_right_greater_than_start_pos()
        {
            Vector3 startPos = _playerController.transform.position;
            
            _playerController.InputReader.Horizontal.Returns(1f);
            yield return new WaitForSeconds(3f);
            
            Assert.Greater(_playerController.transform.position.x, startPos.x);
        }
        
        [UnityTest]
        public IEnumerator Player_move_left_less_than_start_pos()
        {
            Vector3 startPos = _playerController.transform.position;
            
            _playerController.InputReader.Horizontal.Returns(-1f);
            yield return new WaitForSeconds(3f);
            
            Assert.Less(_playerController.transform.position.x, startPos.x);
        }
        
    }
}