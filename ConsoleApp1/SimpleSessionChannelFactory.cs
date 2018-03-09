using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace ConsoleApp1
{
    public class SimpleSessionChannelFactory<TChannel>
        : SimpleChannelFactoryBase<TChannel>
    {
        public SimpleSessionChannelFactory(BindingContext context)
            : base(context)
        {

        }

        protected override TChannel OnCreateChannel(EndpointAddress address, Uri via)
        {
            IDuplexSessionChannel innerChannel =
                this.InnerChannelFactory.CreateChannel(address, via) as IDuplexSessionChannel;
            return (TChannel)(object)new SimpleDuplexSessionChannel(this, innerChannel);
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
