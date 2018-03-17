using Calculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Services.Tests
{
    [TestFixture]
    public class RegisterTests
    {
        [Test]
        public void AddTwoNumbersTest_ReturnsResult()
        {
            //arrange
            Register testObj = new Register();
            int firstNum = 2;
            int secondNum = 4;

            //act
            var result = testObj.AddTwoNumbers(firstNum, secondNum);
            var expected = firstNum + secondNum;
            //assert
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}