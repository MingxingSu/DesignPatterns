using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TemplateMethod
{
    internal class Coffee : CaffeineBeverage
    {
        public Coffee(string userCustomRequire)
        {
            this.UserCustomRequire = userCustomRequire;
        }

        public string UserCustomRequire { get; set; }


        public override void Brew()
        {
            Console.WriteLine("Putting coffee bar");
        }

        public override bool IsAddCondiments()
        {
            if (UserCustomRequire.Equals("Y"))
            {
                return true;
            }

            return base.IsAddCondiments();
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding milk and sugar");
        }
    }
}
