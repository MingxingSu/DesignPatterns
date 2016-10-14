using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var sington1 = Singleton.GetInstance();
            var sington2 = Singleton.GetInstance();

            Console.WriteLine("Are the singleton1 and singleton2 same object:"+ReferenceEquals(sington1,sington2));
            Console.ReadKey();
        }
    }
}
