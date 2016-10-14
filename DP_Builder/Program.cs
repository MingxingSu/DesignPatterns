using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder
{
    class Program
    {
        //产品类：一般是一个较为复杂的对象，也就是说创建对象的过程比较复杂，一般会有比较多的代码量。在本类图中，产品类是一个具体的类，而非抽象类。实际编程中，产品类可以是由一个抽象类与它的不同实现组成，也可以是由多个抽象类与他们的实现组成。
        
        //抽象建造者：引入抽象建造者的目的，是为了将建造的具体过程交与它的子类来实现。这样更容易扩展。一般至少会有两个抽象方法，一个用来建造产品，一个是用来返回产品。
        
        //建造者：实现抽象类的所有未实现的方法，具体来说一般是两项任务：组建产品；返回组建好的产品。
        
        //导演类：负责调用适当的建造者来组建产品，导演类一般不与产品类发生依赖关系，与导演类直接交互的是建造者类。一般来说，导演类被用来封装程序中易变的部分。
        static void Main(string[] args)
        {
            PersonDirector nvwa = new PersonDirector();
            var person =nvwa.ConstructPerson(new ManBuilder());
            Console.WriteLine(person.Head);
            Console.WriteLine(person.Body);
            Console.WriteLine(person.Foot);
            Console.ReadKey();

            //如果系统中只需要一个具体的建造者的话，可以省略掉抽象建造者。

            //在具体建造者只有一个的情况下，如果抽象建造者角色已经被省略掉，那么还可以省略掉指导者角色，让Builder自己扮演指导者和建造者双重角色。
            
            //Max's comments：此时把build各部分的代码都移入GetPerson方法中即可，不再需要Director指导如何创建，因为Builder自己知道。
            //这不就是单干的程序员嘛，Director就是PM，抽象建造者是架构师。


            //使用建造者模式的好处：

            //1.使用建造者模式可以使客户端不必知道产品内部组成的细节。
            //2.具体的建造者类之间是相互独立的，对系统的扩展非常有利。
            //3.由于具体的建造者是独立的，因此可以对建造过程逐步细化，而不对其他的模块产生任何影响。

            //使用建造模式的场合：
            //1.创建一些复杂的对象时，这些对象的内部组成构件间的建造顺序是稳定的，但是对象的内部组成构件面临着复杂的变化。
            //2.要创建的复杂对象的算法，独立于该对象的组成部分，也独立于组成部分的装配方法时。
        }
    }
}
