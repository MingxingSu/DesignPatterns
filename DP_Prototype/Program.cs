using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //在.NET中可以很容易地通过实现ICloneable接口（这个接口就是原型，提供克隆方法，相当于与上面代码中MonkeyKingPrototype抽象类）中Clone()方法来实现原型模式，如果我们想我们自定义的类具有克隆的功能，首先定义类继承与ICloneable接口并实现Clone方法。
            // 孙悟空 原型
            MonkeyKingPrototype prototypeMonkeyKing = new ConcretePrototype("MonkeyKing");


            // 变一个
            MonkeyKingPrototype cloneMonkeyKing = prototypeMonkeyKing.Clone() as ConcretePrototype;
            Console.WriteLine("Cloned1: " + cloneMonkeyKing.Id);


            // 变两个
            MonkeyKingPrototype cloneMonkeyKing2 = prototypeMonkeyKing.Clone() as ConcretePrototype;
            Console.WriteLine("Cloned2: " + cloneMonkeyKing2.Id);


            //在.NET中可以很容易地通过实现ICloneable接口（这个接口就是原型，提供克隆方法，相当于与上面代码中MonkeyKingPrototype抽象类）中Clone()方法来实现原型模式，
            //如果我们想我们自定义的类具有克隆的功能，首先定义类继承与ICloneable接口并实现Clone方法。

            //原型模式的优点有：

            //原型模式向客户隐藏了创建新实例的复杂性0
            //原型模式允许动态增加或较少产品类。
            //原型模式简化了实例的创建结构，工厂方法模式需要有一个与产品类等级结构相同的等级结构，而原型模式不需要这样。
            //产品类不需要事先确定产品的等级结构，因为原型模式适用于任何的等级结构
            //原型模式的缺点有：

            //每个类必须配备一个克隆方法
            // 配备克隆方法需要对类的功能进行通盘考虑，这对于全新的类不是很难，但对于已有的类不一定很容易，特别当一个类引用不支持串行化的间接对象，或者引用含有循环结构的时候。

            //Sample 2:内置ICloneable
            CellPrototype cellPrototype = new CellPrototype("Cell");
            CellPrototype cellClone1 = (CellPrototype)cellPrototype.Clone();
            Console.WriteLine("Cloned for Cell: " + cellClone1.Id);
            Console.ReadLine();

        }
    }
}
