using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SimpleDatagramChannelFactory<TChannel>
        : SimpleChannelFactoryBase<TChannel>
    {
        public SimpleDatagramChannelFactory(BindingContext context) : base(context)
        {
        }

        protected override TChannel OnCreateChannel(EndpointAddress address, Uri via)
        {
            this.Print("OnCreateChannel(EndpointAddress address, Uri via)");
            IRequestChannel innerChannel = this.InnerChannelFactory.CreateChannel(address, via) as IRequestChannel;
            return (TChannel)(object)new SimpleRequestChannel(this, innerChannel);
        }

        protected override void OnEndOpen(IAsyncResult result)
        {
            throw new NotImplementedException();
        }

        protected override void OnOpen(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }
    }
}
