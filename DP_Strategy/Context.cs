using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy
{

    public class TaxCounterContext
    {
        public TaxCounterContext(IStrategy strategy)
        {
            _taxStrategy = strategy;
        }

        private readonly IStrategy _taxStrategy = null;

        public void CollectionTax(double income)
        {
           Console.WriteLine("You should pay tax: "+ _taxStrategy.CaculateTax(income));
        }
    }
}
