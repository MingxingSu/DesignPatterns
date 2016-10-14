using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryMethod
{
    public abstract class BaseMessage
    {
        public string MessageType { get; set; }
        public string MessageExtension { get; set; }
        public abstract void Build();
        public abstract void Validate();

    }
}
