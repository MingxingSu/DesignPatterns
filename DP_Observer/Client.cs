using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Observer
{
    public abstract class  Client
    {
        public string Name { get; set; }

        public abstract void CheckMessage();
    }
}
