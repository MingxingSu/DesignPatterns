using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    //类适配器实现了客户端想要的接口(USB)和被适配对象接口(PS2)，通过继承来实现适配功能。
    public class MultipeAdapters:ISdCardClassAdapters,IHardDisk
    {
        public string ReadDataFromUsbPort(SDCard sdCard)
        {
            return sdCard.ReadData();
        }

        public string ReadHardDiskDataFromUsbPort(HardDisk hardDisk)
        {
            return hardDisk.OutputContent();
        }
    }
}
