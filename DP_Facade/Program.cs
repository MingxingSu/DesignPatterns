using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //外观模式提供了一个统一的接口，用来访问子系统中的一群接口。
            //外观定义了一个高层接口，让子系统更容易使用。
            //使用外观模式时，我们创建了一个统一的类，用来包装子系统中一个或多个复杂的类，客户端可以直接通过外观类来调用内部子系统中方法，从而外观模式让客户和子系统之间避免了紧耦合。


            //优点：

            //外观模式对客户屏蔽了子系统组件，从而简化了接口，减少了客户处理的对象数目并使子系统的使用更加简单。
            //外观模式实现了子系统与客户之间的松耦合关系，而子系统内部的功能组件是紧耦合的。松耦合使得子系统的组件变化不会影响到它的客户。
            //缺点：

            //如果增加新的子系统可能需要修改外观类或客户端的源代码，这样就违背了”开——闭原则“（不过这点也是不可避免）。

            EncryptFacade facade = new EncryptFacade();
            facade.EncryptFile("testdata.txt","output.txt");
            Console.Read();
        }
    }
}
