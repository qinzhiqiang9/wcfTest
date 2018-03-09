using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace ConsoleApp1
{
    public class SimpleDuplexSessionChannel : SimpleChannelBase, IDuplexChannel
    {
        public SimpleDuplexSessionChannel(ChannelManagerBase channelManager, IDuplexSessionChannel innerChannel) : 
            base(channelManager, (ChannelBase)innerChannel)
        {
            Print("SimpleDuplexSessionChannel .ctor");
        }

        public IDuplexSessionChannel InnerDuplexSessionChannel => (IDuplexSessionChannel)this.InnerChannel;

        public EndpointAddress LocalAddress => throw new NotImplementedException();

        public EndpointAddress RemoteAddress => throw new NotImplementedException();

        public Uri Via => throw new NotImplementedException();

        public IAsyncResult BeginReceive(AsyncCallback callback, object state)
        {
            Print("BeginReceive(AsyncCallback callback, object state)");
            return this.InnerDuplexSessionChannel.BeginReceive(callback, state);
        }

        public IAsyncResult BeginReceive(TimeSpan timeout, AsyncCallback callback, object state)
        {
            Print("BeginReceive(TimeSpan timeout, AsyncCallback callback, object state)");
            return this.InnerDuplexSessionChannel.BeginReceive(timeout,callback, state);
        }

        public IAsyncResult BeginSend(Message message, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginSend(Message message, TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginTryReceive(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public IAsyncResult BeginWaitForMessage(TimeSpan timeout, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public Message EndReceive(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public void EndSend(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public bool EndTryReceive(IAsyncResult result, out Message message)
        {
            throw new NotImplementedException();
        }

        public bool EndWaitForMessage(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        public Message Receive()
        {
            throw new NotImplementedException();
        }

        public Message Receive(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public void Send(Message message)
        {
            throw new NotImplementedException();
        }

        public void Send(Message message, TimeSpan timeout)
        {
            throw new NotImplementedException();
        }

        public bool TryReceive(TimeSpan timeout, out Message message)
        {
            throw new NotImplementedException();
        }

        public bool WaitForMessage(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }
    }
}
