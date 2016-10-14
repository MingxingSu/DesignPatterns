using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Prototype
{
    public class CellPrototype:ICloneable
    {
        
        public string Id { get; set; }

        public CellPrototype(string id)
        {
            this.Id = id;
        }

        public object Clone()
        {
            return (CellPrototype) this.MemberwiseClone();
        }
    }
}
