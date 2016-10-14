﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //三层架构中的BLL和DAL就是按照Bridge模式实现的

            //总结：Bridge模式是一个非常有用的模式，也非常复杂，它很好的符合了开放-封闭原则和优先使用对象组合，而不是继承这两个面向对象原则。

            //桥梁模式中的所谓脱耦，就是指在一个软件系统的抽象化和实现化之间使用组合/聚合关系而不是继承关系，从而使两者可以相对独立地变化。这就是桥梁模式的用意
            BusinessObject boCustomer = new CustomersBusinessObject("Beijing");
            DataAccess dalCustomer = new CustomersDataAccess();
            boCustomer.DAL = dalCustomer;

            boCustomer.Add("Xiao liu");
            Console.WriteLine("Result after a member added：");
            boCustomer.ShowAll();
            boCustomer.Delete("Wang Wu");
            Console.WriteLine("Result after a member deleted：");
            boCustomer.ShowAll();
            Console.WriteLine("Result after a member updated：");
            boCustomer.Update("Learning_Hard");
            boCustomer.ShowAll();

            Console.Read();

            /*
             * 效果及实现要点：
                1．Bridge模式使用“对象间的组合关系”解耦了抽象和实现之间固有的绑定关系，使得抽象和实现可以沿着各自的维度来变化。
                2．所谓抽象和实现沿着各自维度的变化，即“子类化”它们，得到各个子类之后，便可以任意它们，从而获得不同路上的不同汽车。
                3．Bridge模式有时候类似于多继承方案，但是多继承方案往往违背了类的单一职责原则（即一个类只有一个变化的原因），复用性比较差。
                   Bridge模式是比多继承方案更好的解决方法。
                4．Bridge模式的应用一般在“两个非常强的变化维度”，有时候即使有两个变化的维度，但是某个方向的变化维度并不剧烈——换言之两个变化不会导致纵横交错的结果，并不一定要使用Bridge模式。

                适用性：
                   在以下的情况下应当使用桥梁模式：
                1．如果一个系统需要在构件的抽象化角色和具体化角色之间增加更多的灵活性，避免在两个层次之间建立静态的联系。 
                2．设计要求实现化角色的任何改变不应当影响客户端，或者说实现化角色的改变对客户端是完全透明的。
                3．一个构件有多于一个的抽象化角色和实现化角色，系统需要它们之间进行动态耦合。 
                4．虽然在系统中使用继承是没有问题的，但是由于抽象化角色和具体化角色需要独立变化，设计要求需要独立管理这两者。


                桥接模式与装饰的区别:
                装饰模式:
                      这两个模式在一定程度上都是为了减少子类的数目，避免出现复杂的继承关系。但是它们解决的方法却各有不同
                        ，装饰模式把子类中比基类中多出来的部分放到单独的类里面，以适应新功能增加的需要，当我们把描述新功能的类封装到基类的对象里面时，
             *          就得到了所需要的子类对象，这些描述新功能的类通过组合可以实现很多的功能组合 .
                桥接模式：
                          桥接模式则把原来的基类的实现化细节抽象出来，在构造到一个实现化的结构中，然后再把原来的基类改造成一个抽象化的等级结构，
             *            这样就可以实现系统在多个维度上的独立变化 。
             */
        }
    }
}