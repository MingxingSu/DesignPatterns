using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Flyweight
{
    public class FontBase
    {
        public FontBase(string name)
        {
            this.FontName = name;
        }

        public virtual void Apply(string words)
        {
            Console.WriteLine("{0} was applied the {1} font", words, FontName);
        }

        public string FontName { get; set; }
    }
}
