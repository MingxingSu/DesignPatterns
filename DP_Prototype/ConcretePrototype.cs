using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Prototype
{
    public class ConcretePrototype : MonkeyKingPrototype
    {
        public override MonkeyKingPrototype Clone()
        {
            return (MonkeyKingPrototype)this.MemberwiseClone();
        }

        public ConcretePrototype(string id) : base(id)
        {
        }
    }
}
