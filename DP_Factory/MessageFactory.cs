using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_SimpleFactory
{
    public class MessageFactory
    {

        public static BaseMessage CreateMessage(string messageType)
        {
            if (messageType == "MT101")
            {
                return new MT101Message();
            }
            else if (messageType == "Pain001")
            {
                return new Pain001Message();
            }

            throw new Exception("Message Type not found");
        }
    }
}
