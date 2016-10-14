using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //模式中的角色

            //  3.1 目标接口（Target）：客户所期待的接口。目标可以是具体的或抽象的类，也可以是接口。

            //  3.2 需要适配的类（Adaptee）：需要适配的类或适配者类。

            //  3.3 适配器（Adapter）：通过包装一个需要适配的对象，把原接口转换成目标接口。　　

            //　注：在GoF的设计模式中，对适配器模式讲了两种类型，类适配器模式和对象适配器模式。
            //类适配只能通过接口实现，对象适配器，可以是接口，也可以是抽象类。


            //差别就是：对象适配器实现了客户端想要的接口(USB)，在内部有一个被适配对象(PS2)的引用，通过组合实现适配功能。类适配器实现了客户端想要的接口(USB)和被适配对象接口(PS2)，通过继承来实现适配功能。
            ISdCardClassAdapters sdCardClassAdapter = new MultipeAdapters();
            Console.WriteLine(sdCardClassAdapter.ReadDataFromUsbPort(new SDCard()));

            IHardDisk hdClassAdapter = new MultipeAdapters();
            Console.WriteLine(hdClassAdapter.ReadHardDiskDataFromUsbPort(new HardDisk()));

            SDCard scCard = new SDCard();
            SdCardInstanceAdapter sdCardInstanceAdapter = new SdCardInstanceAdapter(scCard);
            Console.WriteLine(sdCardInstanceAdapter.ReadDataFromUsbPort());

            Console.ReadKey();

        }
    }
}
