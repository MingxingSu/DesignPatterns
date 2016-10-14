using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses。
            //定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使一个类的实例化延迟到其子类。

            //因为把具体工厂抽象为抽象工厂，不再需要在具体工厂中，if-else分类集中创建具体产品。
            var mt101Factory = new MT101Factory();
            var messageMt101 = mt101Factory.CreateMessage();
            messageMt101.Build();
            messageMt101.Validate();

            var pain001Factory = new Pain001Factory();
            var messagePain001 = pain001Factory.CreateMessage();
            messagePain001.Build();
            messagePain001.Validate();
        }
    }
}
