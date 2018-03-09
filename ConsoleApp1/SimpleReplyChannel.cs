using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SimpleReplyChannel : SimpleChannelBase, IReplyChannel
    {
        public SimpleReplyChannel(ChannelManagerBase channelManager, IReplyChannel innerChannel) 
            : base(channelManager, (ChannelBase)innerChannel)
        {
        }

        public IReplyChannel InnerReplyChannel => (IReplyChannel)this.InnerChannel;
        public EndpointAddress LocalAddress => throw new NotImplementedException();

        public IAsyncResult BeginReceiveRequest(AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginReceiveRequest(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginTryReceiveRequest(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginWaitForRequest(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public RequestContext EndReceiveRequest(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public bool EndTryReceiveRequest(IAsyncResult result, out RequestContext context)
        {
            throw new NotImplementedException();
        }

        public bool EndWaitForRequest(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public RequestContext ReceiveRequest()
        {
            throw new NotImplementedException();
        }

        public RequestContext ReceiveRequest(TimeSpan timeout)
        {
            this.Print("ReceiveRequest(TimeSpan timeout)");
            return this.InnerReplyChannel.ReceiveRequest(timeout);
        }

        public bool TryReceiveRequest(TimeSpan timeout, out RequestContext context)
        {
            throw new NotImplementedException();
        }

        public bool WaitForRequest(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }
    }
}
