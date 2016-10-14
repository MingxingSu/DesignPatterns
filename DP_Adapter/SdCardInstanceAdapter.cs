using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Adapter
{

    public class SdCardInstanceAdapter
    {
        //在内部有一个被适配对象(PS2)的引用，通过组合实现适配功能。
        private readonly  SDCard _sdCard = null;

        public SdCardInstanceAdapter(SDCard sdCard)
        {
            _sdCard = sdCard;
        }

        //对象适配器实现了客户端想要的接口(USB)
        public string ReadDataFromUsbPort()
        {
            return _sdCard.ReadData();
        }
    }
}
