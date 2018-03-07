using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using wcfService.Interface;

namespace ClientWithChannel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>(new WSHttpBinding(), "http://localhost:9876/calculatorservice"))
            {
                var calculator = channelFactory.CreateChannel();
                var result = calculator.Add(1D, 3D);
                Console.WriteLine(result);
                Console.Read();
            }
        }
    }
}
