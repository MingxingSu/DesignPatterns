using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Facade
{
    class CipherMachine
    {
        public string Encrypt(string plainText)
        {
            Console.Write("Data Encrypt，transfter message to encrypted codes:");
            string es = "";
            char[] chars = plainText.ToCharArray();
            foreach (char ch in chars)
            {
                string c = (ch % 7).ToString();
                es += c;
            }
            Console.WriteLine(es);
            return es;
        }  
    }
}
