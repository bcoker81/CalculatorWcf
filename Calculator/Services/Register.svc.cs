using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Calculator.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Register" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Register.svc or Register.svc.cs at the Solution Explorer and start debugging.
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
            return num1 / num2;
        }

        public double Exponent(int num1, int num2)
        {
            return Math.Pow(num1,num2);
        }
    }
}
