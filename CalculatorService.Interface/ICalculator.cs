using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace wcfService.Interface
{
    [ServiceContract(Name = "CalculatorService")]
    public interface ICalculator
    {
        [OperationContract]
        double Add(double x, double y);
    }
}
