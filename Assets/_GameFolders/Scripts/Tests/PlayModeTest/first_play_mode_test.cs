using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace PlayModeTest
{
    public class first_play_mode_test
    {
        
        [UnityTest]
        public IEnumerator SumNumbersTest()
        {
            // Arrange
            int number1 = 10;
            int number2 = 20;
            int expectedResult = 30;
        
            // Act
            int actualResult = number1 + number2;
        
            // Assert
            Assert.AreEqual(expectedResult, actualResult);

            yield return null;
        }
        
        [UnityTest]
        public IEnumerator CreateGameObjectTest()
        {
            // Arrange
            string name = "NewObj";
            GameObject obj = new GameObject(name);
            
            // Act
            yield return new WaitForSeconds(1);
            GameObject findObj = GameObject.Find(name);
            yield return new WaitForSeconds(1);
            
            // Assert
            Assert.IsNotNull(findObj);
            Assert.AreSame(obj, findObj);

            yield return null;
        }
    }
}
