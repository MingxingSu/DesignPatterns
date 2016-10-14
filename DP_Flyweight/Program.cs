using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            /*享元模式——运用共享技术有效地支持大量细粒度的对象。
             * 
             * 享元模式可以避免大量相似类的开销，在软件开发中如果需要生成大量细粒度的类实例来表示数据，如果这些实例除了几个参数外基本上都是相同的，
             * 这时候就可以使用享元模式来大幅度减少需要实例化类的数量。
             *  如果能把这些参数（指的这些类实例不同的参数）移动类实例外面，在方法调用时将他们传递进来，这样就可以通过共享大幅度地减少单个实例的数目。
             *  （这个也是享元模式的实现要领）,然而我们把类实例外面的参数称为享元对象的外部状态，把在享元对象内部定义称为内部状态。
             *  
            具体享元对象的内部状态与外部状态的定义为：
            内部状态：在享元对象的内部并且不会随着环境的改变而改变的共享部分
            外部状态：随环境改变而改变的，不可以共享的状态。*/


            /*Sample:这个例子是：一个文本编辑器中会出现很多字面，使用享元模式去实现这个文本编辑器的话，会把每个字面做成一个享元对象。
             * 享元对象的内部状态就是这个字面，而字母在文本中的位置和字体风格等其他信息就是它的外部状态。*/
            var fontFactory = new FontFactory();
            fontFactory.AddFont(new ChineseFont());
            fontFactory.AddFont(new EnglishFont());
            var font1 = fontFactory.CreateFont("ChineseFont");//Add again
            var font2 = fontFactory.CreateFont("SongTi");
            var font3 = fontFactory.CreateFont("ChineseFont");
            var font4 = fontFactory.CreateFont("EnglishFont");
            font1.Apply("hello");
            font2.Apply("world");
            font3.Apply("haha");
            font4.Apply("hehe");
            

            Console.WriteLine(font1.Equals(font2));
            Console.WriteLine(font1.Equals(font3));
            Console.Read();
        }
    }
}
