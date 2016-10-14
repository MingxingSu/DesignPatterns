using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Interpreter
{
    class Program
    {
        //


        static void Main(string[] args)
        {
            //意图（Intent）:给定一个语言，定义它的文法的一种表示，并定义一种解释器，这个解释器使用该表示来解释语言中的句子。
            //Interpreter模式的应用场合是Interpreter模式应用中的难点，只有满足“业务规则频繁变化，且类似的模式不断重复出现，并且容易抽象为语法规则的问题”才适合使用Interpreter模式。
            //正则表达式就是一个典型的解释器。ASP.NET中，把aspx文件转化为dll时，会对html语言进行处理，这个处理过程也包含了解释器的模式在里面。Interpreter模式其实有Composite模式的影子，但它们解决的问题是不一样的。

            //Demo:将汉字转化为数字

            //Solution 1:  不用设计模式的解决办法
            string statement = "五万八千六百四十三";
            ArrayList expTree = new ArrayList();
            Contetxt contetxt = new Contetxt(statement);

            expTree.Add(new GeExpression());
            expTree.Add(new ShiExpression());
            expTree.Add(new BaiExpression());
            expTree.Add(new QianExpression());
            expTree.Add(new WanExpression());

            foreach (ExpressionBase exp in expTree)
            {
                exp.Interpreter(contetxt);
                
            }
            Console.WriteLine("{0} = {1}", statement, contetxt.Data);
            Console.Read();


        }

    }
}
