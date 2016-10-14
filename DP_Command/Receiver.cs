using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Command
{
    public class Receiver
    {
        public void ActionNow()
        {
            State = "Action Enabled";
            Console.WriteLine("I am following your command , current state is " + State);
        }

        public string State { get; set; }

        public void UnDo()
        {
            State = String.Empty;
            Console.WriteLine("I am following your command , current state is " + State);
        }



    }

    //命令接收者
    public class Tv
    {
        public int CurrentChannel { get; set; }


        public void TurnOn()
        {
            Console.WriteLine("The televisino is on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The television is off.");
        }

        public void ChangeChannel(int channel)
        {
            this.CurrentChannel = channel;
            Console.WriteLine("Now TV channel is " + channel);
        }
    }
}
