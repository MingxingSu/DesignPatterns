using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //模板方法定义： 在一个方法中定义一个算法的骨架（模板方法），而将一些步骤延迟到子类中实现。 模板方法使得子类可以在不改变算法结构的情况下，重新定义算法中的某些步骤
            //还可以重写钩子方法，控制跳过算法中的某些步骤。
            Console.WriteLine("Would you like to add sugar adn milk for your coffe, Y or N?");
            string userChosenOption = Console.ReadLine();
            CaffeineBeverage coffe = new Coffee(userChosenOption);
            coffe.PrepareRecipe();

            CaffeineBeverage tea = new Tea();
            tea.PrepareRecipe();

            Console.Read();

        }
    }
}
