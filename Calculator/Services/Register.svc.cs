using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Calculator.Services
{
    public class Register : IRegister
    {
        public int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public int SubtractTwoNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        public int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        public int DivideTwoNumbers(int num1, int num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else return 0;
        }

        public double Exponent(int num1, int num2)
        {
            return Math.Pow(num1,num2);
        }
    }
}
