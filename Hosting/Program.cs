using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using wcfService.Interface;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                //host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "http://localhost:9876/calculatorservice");
                //if(host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                //{
                //    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                //    behavior.HttpGetEnabled = true;
                //    behavior.HttpGetUrl = new Uri("http://localhost:9876/calculatorservice/metadata");
                //    host.Description.Behaviors.Add(behavior);
                //}

                host.Opened += (o, e) => Console.WriteLine("Service opened.");
                host.Open();
                Console.ReadKey();
            }
        }
    }
}
