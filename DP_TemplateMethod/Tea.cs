using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_TemplateMethod
{
    class Tea:CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Putting tea bag");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding some sugar to tea ");
        }
    }
}
