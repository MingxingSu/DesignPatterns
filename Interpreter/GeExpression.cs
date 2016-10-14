using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Interpreter
{
    class GeExpression:ExpressionBase
    {
        public override string GetPostfix()
        {
            return "";
        }

        public override int Mutiplier
        {
            get { return 1; }
        }

        public override int GetLengh()
        {
            return 1;
        }
    }
}
