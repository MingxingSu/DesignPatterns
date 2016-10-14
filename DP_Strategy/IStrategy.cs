using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy
{
    public interface IStrategy
    {
        double CaculateTax(double income);
    }
}
