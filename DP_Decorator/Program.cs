using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator
{
    class Program
    {
        /*
         *  抽象构件（Phone）角色：给出一个抽象接口，以规范准备接受附加责任的对象。
            具体构件（AppPhone）角色：定义一个将要接收附加责任的类。
            装饰（Dicorator）角色：持有一个构件（Component）对象的实例，并定义一个与抽象构件接口一致的接口。
            具体装饰（Sticker和Accessories）角色：负责给构件对象 ”贴上“附加的责任。
         */
        static void Main(string[] args)
        {         
            //装饰模式：以对客户端透明的方式扩展对象的功能，是继承关系的一个替代方案；
            //代理模式：给一个对象提供一个代理对象，并有代理对象来控制对原有对象的引用；

            //装饰模式应该为所装饰的对象增强功能；代理模式对代理的对象施加控制，并不提供对象本身的增强功能

            //二者的实现机制确实是一样的，可以看到他们的实例代码重复是很多的。但就语义上说，这两者的功能是相反的，模式的一个重要作用是简化其他程序员对你程序的理解，

            //你在一个地方写装饰，大家就知道这是在增加功能，你写代理，大家就知道是在限制，虽然代码很可能相同，但如果你都叫他们装饰，别人会很迷惑的。

            Phone myPhone = new ApplePhone();

            //add sticker
            Decorator stickDecorator = new Sticker(myPhone);
            stickDecorator.AddAccessary();
            Console.WriteLine("-----------");

            //Add cover
            Decorator coverDecorator = new Cover(myPhone);
            coverDecorator.AddAccessary();
            Console.WriteLine("-----------");

            //Add both sticker and cover
            Sticker sticker = new Sticker(myPhone);
            Cover coverForPhoneWithSticker = new Cover(sticker);
            coverForPhoneWithSticker.AddAccessary();

            //Add both cover and sticker
            Console.WriteLine("-----------");
            Cover cover = new Cover(myPhone);
            Sticker applePhoneWitCoverAndSticker = new Sticker(cover);
            applePhoneWitCoverAndSticker.AddAccessary();
            Console.ReadKey();


        }
    }
}
