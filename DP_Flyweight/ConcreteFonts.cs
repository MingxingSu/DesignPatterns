using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Flyweight
{
    public class ChineseFont : FontBase
    {
        public ChineseFont()
            : base("ChineseFont")
        {
           
        }
    }

    public class EnglishFont : FontBase
    {
        public EnglishFont()
            : base("EnglishFont")
        {
          
        }
    }
}
