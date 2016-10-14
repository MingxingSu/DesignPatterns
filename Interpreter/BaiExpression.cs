using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Interpreter
{
    class BaiExpression:ExpressionBase
    {
        public override string GetPostfix()
        {
            return "百";
        }

        public override int Mutiplier
        {
            get { return 100; }
        }
    }
}
