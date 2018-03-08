using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://localhost:9876/calculatorservice");
            var header = AddressHeader.CreateAddressHeader("UserName", "http://localhost:9876", "jqin");
            EndpointAddress address = new EndpointAddress(uri, header);

            using (var client = new ServiceReference1.CalculatorServiceClient(new WSHttpBinding(), address))
            { 
                double result = client.Add(1D, 2D);
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}
