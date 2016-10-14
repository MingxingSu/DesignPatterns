using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        //template method
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();

            if (IsAddCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();//由子类实现
        public abstract void AddCondiments();//由子类实现

        //所有的子类都有相同的实现
        private void BoilWater()
        {
            Console.WriteLine("Bolling Water");
        }

        //所有的子类都有相同的实现
        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public virtual bool IsAddCondiments()
        {
            return false;
        }

    }
}
