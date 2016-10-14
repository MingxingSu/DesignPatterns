using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator
{
    //Abstract Component
    public abstract class Phone
    {
        public abstract void AddAccessary();
    }

    /// <summary>
    /// Concrete Component 
    /// </summary>
    public class ApplePhone : Phone
    {
        public override void AddAccessary()
        {
            Console.WriteLine("Apple phone start to add accessary!");
        }
    }


}
