using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Proxy
{
    public class RemoteServiceClass:IProxy
    {
        public string RequestData()
        {
            return "this is big data from remote server";
        }
    }
}
