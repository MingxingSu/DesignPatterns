using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Interpreter
{
    class QianExpression:ExpressionBase
    {
        public override string GetPostfix()
        {
            return "千";
        }

        public override int Mutiplier
        {
            get { return 1000; }
        }
    }
}
