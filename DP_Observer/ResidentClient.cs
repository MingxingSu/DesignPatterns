using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer
{
    public class ResidentClient:Client
    {
        public string RoomNumber { get;set; }
        public int BoardSection { get; set; }

        public override void CheckMessage()
        {
            ReadBoardMessage();
            ReadMessageInMobile();
        }

        private void ReadMessageInMobile()
        {
            Console.WriteLine("I have known the message from my mobile!");
        }


        private void ReadBoardMessage()
        {
            Console.WriteLine("I have known the message from the board of the building!");
        }
    }
}
