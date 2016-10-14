using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Prototype
{
    public  abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }
        protected MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        public abstract MonkeyKingPrototype Clone();
    }
}
