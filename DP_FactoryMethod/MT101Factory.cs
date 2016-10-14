using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryMethod
{
    public class MT101Factory:IMessageFactory
    {
        public BaseMessage CreateMessage()
        {
           return new MT101Message();
        }

        public void SendMessage(BaseMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
