using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DP_Interpreter
{
    public abstract class ExpressionBase
    {
        protected Dictionary<string, int>  MapperDict = new Dictionary<string, int>();

        protected ExpressionBase()
        {
            MapperDict.Add("一", 1);
            MapperDict.Add("二", 2);
            MapperDict.Add("三", 3);
            MapperDict.Add("四", 4);
            MapperDict.Add("五", 5);
            MapperDict.Add("六", 6);
            MapperDict.Add("七", 7);
            MapperDict.Add("八", 8);
            MapperDict.Add("九", 9);
        }

        public virtual void Interpreter(Contetxt contetxt)
        {
            
            foreach (var key in MapperDict.Keys)
            {
                int value = MapperDict[key];

                if (contetxt.Statement.EndsWith(key + GetPostfix()))
                {
                    contetxt.Data += value*this.Mutiplier;
                    contetxt.Statement = contetxt.Statement.Substring(0, contetxt.Statement.Length - 2);
                }

                if (contetxt.Statement.EndsWith("零"))
                {
                    contetxt.Statement = contetxt.Statement.Substring(0, contetxt.Statement.Length - 1);
                }
            }
        }

        public abstract string GetPostfix();
        public abstract int Mutiplier { get; }

        public virtual int GetLengh()
        {
            return this.GetPostfix().Length + 1;
        }


    }
}
