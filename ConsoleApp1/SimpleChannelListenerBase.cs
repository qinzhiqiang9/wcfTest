using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace ConsoleApp1
{
    public abstract class SimpleChannelListenerBase<TChannel> : ChannelListenerBase<TChannel> where TChannel : class, IChannel
    {
        public IChannelListener<TChannel> InnerChannelListener { get; private set; }

        
        public SimpleChannelListenerBase(BindingContext context) {
            this.InnerChannelListener = context.BuildInnerChannelListener<TChannel>();
        }

        protected override IAsyncResult OnBeginAcceptChannel(TimeSpan timeout, AsyncCallback callback, object state)
        {
            Print("OnBeginAcceptChannel(TimeSpan timeout, AsyncCallback callback, object state)");
            return this.InnerChannelListener.BeginAcceptChannel(timeout, callback, state);
        }

        public override T GetProperty<T>()
        {
            Print("GetProperty<T>()");
            return this.InnerChannelListener.GetProperty<T>();
        }

        protected void Print(string methodName)
        {
            Console.WriteLine($"{this.GetType().Name}.{methodName}");
        }
    }
}
