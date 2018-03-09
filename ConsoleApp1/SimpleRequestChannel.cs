using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace ConsoleApp1
{
    public class SimpleRequestChannel : SimpleChannelBase, IRequestChannel
    {
        public SimpleRequestChannel(ChannelManagerBase channelManager, IRequestChannel innerChannel) 
            : base(channelManager, (ChannelBase)innerChannel)
        {
        }

        public IRequestChannel InnerRequestChannel => (IRequestChannel)this.InnerChannel;

        public EndpointAddress RemoteAddress => throw new NotImplementedException();

        public Uri Via => throw new NotImplementedException();

        public IAsyncResult BeginRequest(Message message, AsyncCallback callback, object state)
        {
            Print("BeginRequest(Message message, AsyncCallback callback, object state)");
            return this.InnerRequestChannel.BeginRequest(message, callback, state);
        }

        public IAsyncResult BeginRequest(Message message, TimeSpan timeout, AsyncCallback callback, object state)
        {
            Print("BeginRequest(Message message, TimeSpan timeout, AsyncCallback callback, object state)");
            return this.InnerRequestChannel.BeginRequest(message, timeout, callback, state);
        }

        public Message EndRequest(IAsyncResult result)
        {
            Print("EndRequest(IAsyncResult result)");
            return InnerRequestChannel.EndRequest(result);
        }

        public Message Request(Message message)
        {
            Print("Request(Message message)");
            return InnerRequestChannel.Request(message);
        }

        public Message Request(Message message, TimeSpan timeout)
        {
            Print("Request(Message message, TimeSpan timeout)");
            return InnerRequestChannel.Request(message, timeout);
        }
    }
}
