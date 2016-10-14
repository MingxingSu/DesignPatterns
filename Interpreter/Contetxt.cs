using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Interpreter
{
    public class Contetxt
    {
        public Contetxt(string statement)
        {
            this.Statement = statement;
        }

        public string Statement { get; set; }
        public int Data { get; set; }
    }
}
