using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{
    public interface ISdCardClassAdapters
    {
        string ReadDataFromUsbPort(SDCard sdCard);
    }

    public interface IHardDisk
    {
        string ReadHardDiskDataFromUsbPort(HardDisk hardDisk);
    }
}
