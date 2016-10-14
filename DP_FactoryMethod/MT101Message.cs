using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryMethod
{
    public  class MT101Message:BaseMessage
    {
        public MT101Message()
        {
            base.MessageExtension = ".txt";
            base.MessageType = "MT101";
        }

        public override void Build()
        {
            Console.WriteLine( base.MessageType + " is being built!");
        }

        public override void Validate()
        {
            Console.WriteLine(base.MessageType + " is being validated!");
        }
    }
}
