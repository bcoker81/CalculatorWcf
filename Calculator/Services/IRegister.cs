using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Calculator.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRegister" in both code and config file together.
    [ServiceContract]
    public interface IRegister
    {
        [OperationContract]
        int AddTwoNumbers(int num1, int num2);
    }
}
