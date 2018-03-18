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
        private static Register TestObj;

        [SetUp]
        public void Setup()
        {
            TestObj = new Register();
        }

        [Test]
        public void AddTwoNumbersTest_ReturnsResult()
        {
            //arrange
            int firstNum = 2;
            int secondNum = 4;

            //act
            var result = TestObj.AddTwoNumbers(firstNum, secondNum);
            var expected = firstNum + secondNum;
            //assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void SubtractTwoNumbers_ReturnsResult()
        {
            //arrange
            int num1 = 4;
            int num2 = 2;

            //act
            var actual = TestObj.SubtractTwoNumbers(num1, num2);
            var expected = num1 - num2;

            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void MultiplyTwoNumbers_ReturnsResult()
        {
            //arrange
            int num1 = 14;
            int num2 = 33;

            //act
            var actual = TestObj.MultiplyTwoNumbers(num1, num2);
            var expected = num1 * num2;

            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void DivideTwoNumbers_ReturnsResult()
        {
            //arrange
            int num1 = 33;
            int num2 = 14;

            //act
            var actual = TestObj.DivideTwoNumbers(num1, num2);
            var expected = num1 / num2;

            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void DivideTwoNumbers_ByZero()
        {
            //arrange
            int num1 = 13;
            int num2 = 0;

            //act
            var actual = TestObj.DivideTwoNumbers(num1, num2);
            var expected = 0;

            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void NumberWithExponent_ReturnsResult()
        {
            //arrange
            int num1 = 3;
            int num2 = 4;

            //act
            var actual = TestObj.Exponent(num1, num2);
            var expected = Math.Pow(num1,num2);

            //assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}