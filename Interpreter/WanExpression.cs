using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Interpreter
{
    class WanExpression:ExpressionBase
    {
        public override string GetPostfix()
        {
            return "万";
        }

        public override int Mutiplier
        {
            get { return 10000; }
        }

        public override void Interpreter(Contetxt contetxt)
        {
            if(contetxt.Statement.Length == 0)
                return;
            ArrayList tree = new ArrayList();
            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());

            foreach (var key in MapperDict.Keys)
            {
                if (contetxt.Statement.EndsWith(this.GetPostfix()))
                {
                    int temp = contetxt.Data;
                    contetxt.Data = 0;

                    contetxt.Statement = contetxt.Statement.Substring(0, contetxt.Statement.Length - 1);
                    
                    //迭代解释‘万’之前的expression
                    foreach (ExpressionBase exp in tree)
                    {
                        exp.Interpreter(contetxt);
                    }

                    contetxt.Data = temp + this.Mutiplier*contetxt.Data;
                }

            }
        }
    }
}
