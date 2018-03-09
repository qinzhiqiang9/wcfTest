using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SimpleDatagramBindingElement : BindingElement
    {
        protected void Print(string methodName)
        {
            Console.WriteLine($"{this.GetType().Name}.{methodName}");
        }

        public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context)
        {
            return new SimpleDatagramChannelListener<TChannel>(context);
        }

        public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context)
        {
            return new SimpleDatagramChannelFactory<TChannel>(context);
        }

        public override BindingElement Clone()
        {
            return new SimpleDatagramBindingElement();
        }

        public override T GetProperty<T>(BindingContext context)
        {
            return context.GetInnerProperty<T>();
        }
    }
}
