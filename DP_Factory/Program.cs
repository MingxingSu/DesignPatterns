using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //此模式有三种角色：工厂--Creator, 抽象产品--Product，具体产品--ConcreteProduct,再加一个抽象工厂角色，则变为工厂方法模式。

            //此模式封装了“具体产品增加”这个变量，有利于扩展新的产品，但仍需要修改工厂类.
            BaseMessage mt101Message = MessageFactory.CreateMessage("MT101");
            mt101Message.Build();
            mt101Message.Validate();
            BaseMessage pain001Message = MessageFactory.CreateMessage("Pain001");
            pain001Message.Build();
            pain001Message.Validate();

            Console.ReadKey();
        }
    }
}
