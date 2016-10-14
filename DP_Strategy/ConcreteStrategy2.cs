using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy
{
    public class PersonalTaxStrategy:IStrategy
    {

        public double CaculateTax(double income)
        {
            return income*0.12;
        }
    }
}
