using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Facade
{
    class EncryptFacade
    {
        private FileReader reader;
        private CipherMachine cipherMachine;
        private FileWriter writer;

        public EncryptFacade()
        {
            reader = new FileReader();
            cipherMachine = new CipherMachine();
            writer = new FileWriter();
        }

        public void EncryptFile(string fileNameSrc, string fileNameDes)
        {
            string content = reader.Read(fileNameSrc);
            string result = cipherMachine.Encrypt(content);
            writer.Write(result,fileNameDes);
        }
    }
}
