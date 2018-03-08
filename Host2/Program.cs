using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wcfService.Interface;
using System.ServiceModel;

namespace Host2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Opened += (o, e) => Console.WriteLine("Service opened.");
                host.Open();
                Console.ReadKey();
            }
        }
    }
}
