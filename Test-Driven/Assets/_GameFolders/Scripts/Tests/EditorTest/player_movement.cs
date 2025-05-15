using _GameFolders.Scripts.Abstracts.Input;
using _GameFolders.Scripts.Abstracts.Interfaces;
using _GameFolders.Scripts.Concretes.Movement;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;

namespace _GameFolders.Scripts.Tests.EditorTest
{
    public class player_movement
    {
        [Test]
        public void move_10_unit_right()
        {
            //Arrange
            IPlayerController playerController = Substitute.For<IPlayerController>();
            GameObject gameObject = new GameObject();
            playerController.transform.Returns(gameObject.transform);
            playerController.InputReader = Substitute.For<IInputReader>();
            IMover mover = new PlayerMoveWithTranslate(playerController);
            Vector3 startPos = playerController.transform.position;

            //Act
            playerController.InputReader.Horizontal.Returns(1f);
            for (int i = 0; i < 10; i++)
            {
                mover.Tick();
                mover.FixedTick();
            }

            Debug.Log("Start Pos => " + startPos);
            Debug.Log("End Pos => " + playerController.transform.position);
            //Assert
            Assert.AreNotEqual(startPos, playerController.transform.position);
        }
        
        [Test]
        public void move_10_unit_right_end_pos_greater_than_start_pos()
        {
            //Arrange
            IPlayerController playerController = Substitute.For<IPlayerController>();
            GameObject gameObject = new GameObject();
            playerController.transform.Returns(gameObject.transform);
            playerController.InputReader = Substitute.For<IInputReader>();
            IMover mover = new PlayerMoveWithTranslate(playerController);
            Vector3 startPos = playerController.transform.position;

            //Act
            playerController.InputReader.Horizontal.Returns(1f);
            for (int i = 0; i < 10; i++)
            {
                mover.Tick();
                mover.FixedTick();
            }

            Debug.Log("Start Pos => " + startPos);
            Debug.Log("End Pos => " + playerController.transform.position);
            //Assert
            Assert.Greater(playerController.transform.position.x, startPos.x);
        }
    }
}