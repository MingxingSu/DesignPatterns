using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_State
{
    class Program
    {
        /*
         * 定义

　　        状态模式的核心思想是:围绕对象的状态，抽象出一个状态基类，并定义了一套相关行为。针对不同的状态，都有的不同的方法来控制对象的行为。以避免以行为为中心时，要针对多种状态用if..else来分辨状态。
         */
        static void Main(string[] args)
        {
            Task task = new Task() {TaskState = new PendingState()};
            task.Start();
            task.Cancel();

            Console.Read();

            //其他samples:房间的预定，入住，退房，退订等。（状态：freeroom, checked in, reserved, cancellation, checked out)

        }

        /*
         *   状态模式的主要优点在于封装了转换规则，并枚举可能的状态，它将所有与某个状态有关的行为放到一个类中，并且可以方便地增加新的状态，只需要改变对象状态即可改变对象的行为，还可以让多个环境对象共享一个状态对象，从而减少系统中对象的个数；
         *   其缺点在于使用状态模式会增加系统类和对象的个数，且状态模式的结构与实现都较为复杂，如果使用不当将导致程序结构和代码的混乱，对于可以切换状态的状态模式不满足“开闭原则”的要求。
         */

        
    }
}
