using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace ConsoleApp1
{
    public abstract class SimpleChannelFactoryBase<TChannel>
        : ChannelFactoryBase<TChannel>
    {
        public IChannelFactory<TChannel> InnerChannelFactory { get; private set; }
        public SimpleChannelFactoryBase(BindingContext context)
        {
            this.InnerChannelFactory = context.BuildInnerChannelFactory<TChannel>();
        }

        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            Print("OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)");
            return this.InnerChannelFactory.BeginOpen(timeout, callback, state);
        }

        public override T GetProperty<T>()
        {
            return this.InnerChannelFactory.GetProperty<T>();
        }

        protected void Print(string methodName)
        {
            Console.WriteLine($"{this.GetType().Name}.{methodName}");
        }
    }
}
