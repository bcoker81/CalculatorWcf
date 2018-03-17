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

        [Test]
        public void SubtractTwoNumbers_ReturnsResult()
        {
            //arrange
            Register testObj = new Register();
            int num1 = 4;
            int num2 = 2;

            //act
            var actual = testObj.SubtractTwoNumbers(num1, num2);
            var expected = num1 - num2;

            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void MultiplyTwoNumbers_ReturnsResult()
        {
            //arrange
            Register testObj = new Register();
            int num1 = 14;
            int num2 = 33;

            //act
            var actual = testObj.MultiplyTwoNumbers(num1, num2);
            var expected = num1 * num2;

            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void DivideTwoNumbers_ReturnsResult()
        {
            //arrange
            Register testObj = new Register();
            int num1 = 33;
            int num2 = 14;

            //act
            var actual = testObj.DivideTwoNumbers(num1, num2);
            var expected = num1 / num2;

            //assert
            Assert.That(expected, Is.EqualTo(actual));

        }
    }
}