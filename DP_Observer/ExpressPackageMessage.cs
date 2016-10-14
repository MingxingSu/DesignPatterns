using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer
{
    public class ExpressPackageMessage:BaseMessage
    {
        public ExpressPackageMessage(string messageContent)
            : base("ExpressPackage", messageContent)
        {
        }

    }
}
