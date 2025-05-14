using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace EditorTest
{
    public class first_edit_test_script
    {
        [Test]
        public void NumbersSumTest()
        {
            // Arrange
            int number1 = 10;
            int number2 = 20;
            int expectedResult = 30;
        
            // Act
            int actualResult = number1 + number2;
        
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    
    }
}
