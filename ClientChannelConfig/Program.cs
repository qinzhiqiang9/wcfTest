using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using wcfService.Interface;

namespace ClientChannelConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>("calculatorService"))
            {
                var calculator = channelFactory.CreateChannel();
                var result = calculator.Add(1D, 3D);
                Console.WriteLine(result);
                Console.Read();
            }
        }
    }
}
