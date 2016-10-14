using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer
{
    public class WaterOffMessage:BaseMessage
    {
        public WaterOffMessage(string messageContent)
            : base("WaterOff", messageContent)
        {
        }
    }
}
