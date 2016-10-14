using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Facade
{
    class FileReader
    {
        public string Read(string fileNameSrc)
        {
            Console.Write("Read file，input message：");
            FileStream fs = null;
            StringBuilder sb = new StringBuilder();
            try
            {
                fs = new FileStream(fileNameSrc, FileMode.Open);
                int data;
                while ((data = fs.ReadByte()) != -1)
                {
                    sb = sb.Append((char)data);
                }
                fs.Close();
                Console.WriteLine(sb.ToString());
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not exists!");
            }
            catch (IOException e)
            {
                Console.WriteLine("File operation error!");
            }
            return sb.ToString();
        }  
    }
}
