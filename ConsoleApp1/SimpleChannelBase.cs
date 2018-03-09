using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace ConsoleApp1
{
    public abstract class SimpleChannelBase : ChannelBase
    {
        public ChannelBase InnerChannel { get; private set; }

        protected SimpleChannelBase(ChannelManagerBase channelManager, ChannelBase innerChannel) 
            : base(channelManager)
        {
            this.InnerChannel = innerChannel;
        }

        protected void Print(string methodName)
        {
            Console.WriteLine($"{this.GetType().Name}.{methodName}");
        }

        protected override void OnClose(TimeSpan timeout)
        {
            Print("OnClose(TimeSpan timeout)");
            this.InnerChannel.Close(timeout);
        }

        public override T GetProperty<T>()
        {
            return this.InnerChannel.GetProperty<T>();
        }

        protected override void OnAbort()
        {
            throw new NotImplementedException();
        }

        protected override void OnEndClose(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override void OnEndOpen(IAsyncResult result)
        {
            throw new NotImplementedException();
        }
    }
}
