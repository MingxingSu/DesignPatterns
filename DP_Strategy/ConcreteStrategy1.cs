using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy
{
    public class CompanyStrategy:IStrategy
    {
        public double CaculateTax(double income)
        {
            return income * 0.17;
        }
    }
}
