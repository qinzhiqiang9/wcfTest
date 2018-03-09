using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;

namespace ConsoleApp1
{
    public class SimpleSessionChannelListener<TChannel>
        : SimpleChannelListenerBase<TChannel> where TChannel : class, IChannel
    {
        public SimpleSessionChannelListener(BindingContext context)
            : base(context)
        {

        }

        public override Uri Uri => throw new NotImplementedException();

        protected override void OnAbort()
        {
            throw new NotImplementedException();
        }

        protected override TChannel OnAcceptChannel(TimeSpan timeout)
        {
            IDuplexSessionChannel innerChannel =
                 this.InnerChannelListener.AcceptChannel(timeout) as IDuplexSessionChannel;
            if (innerChannel != null) {
                return new SimpleDuplexSessionChannel(this, innerChannel) as TChannel;
            }
            return default(TChannel);
        }

        protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override IAsyncResult OnBeginWaitForChannel(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        protected override void OnClose(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        protected override TChannel OnEndAcceptChannel(IAsyncResult result)
        {
            IDuplexSessionChannel innerChannel =
                this.InnerChannelListener.EndAcceptChannel(result) as IDuplexSessionChannel;
            if (innerChannel != null)
            {
                return new SimpleDuplexSessionChannel(this, innerChannel) as TChannel;
            }
            return default(TChannel);
        }

        protected override void OnEndClose(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnEndOpen(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override bool OnEndWaitForChannel(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        protected override bool OnWaitForChannel(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }
    }
}
