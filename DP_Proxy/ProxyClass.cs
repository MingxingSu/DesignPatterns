using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Proxy
{
    public class ProxyClass:IProxy
    {
        public string RequestData()
        {
            RemoteServiceClass remoteService = new RemoteServiceClass();
            return remoteService.RequestData();
        }
    }
}
