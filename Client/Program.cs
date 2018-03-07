using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceReference1.CalculatorServiceClient();
            double result = client.Add(1D, 2D);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
