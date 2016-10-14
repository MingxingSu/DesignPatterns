using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Facade
{
    class FileWriter
    {
        public void Write(string encryptStr, string fileNameDes)
        {
            Console.WriteLine("Save encrypted message，write to file：");
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileNameDes, FileMode.Create);
                byte[] str = Encoding.Default.GetBytes(encryptStr);
                fs.Write(str, 0, str.Length);
                fs.Flush();
                fs.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not exists!");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("File operation error!");
            }
        }  
    }
}
