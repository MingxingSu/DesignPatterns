using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_SimpleFactory
{
    public  class Pain001Message:BaseMessage
    {
        public Pain001Message()
        {
            base.MessageExtension = ".xml";
            base.MessageType = "Pain001";
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

