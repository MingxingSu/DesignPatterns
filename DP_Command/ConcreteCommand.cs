using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Command
{
    public class ConcreteCommand : ICommand
    {
        private readonly Receiver _receiver = null;

        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.ActionNow();
        }

        public void UnDo()
        {
            _receiver.UnDo();
        }
    }


    //开机命令
    public class CommandOn : ICommand
    {
        private Tv myTv;

        public CommandOn(Tv tv)
        {
            myTv = tv;
        }


        public void Execute()
        {
            myTv.TurnOn();
        }

        public void UnDo()
        {
            myTv.TurnOff();
        }
    }

    //关机命令
    public class CommandOff : ICommand
    {
        private Tv myTv;

        public CommandOff(Tv tv)
        {
            myTv = tv;
        }

        public void Execute()
        {
            myTv.TurnOff();
        }
        
        public void UnDo()
        {
            myTv.TurnOn();
        }
    }

    //频道切换命令
    public class CommandChange : ICommand
    {
        private Tv myTv;

        private int channel;
        private Stack<int> chanelsWatched = new Stack<int>();

        public CommandChange(Tv tv, int channel)
        {
            myTv = tv;
            this.channel = channel;
            chanelsWatched.Push(channel);
        }

        public void Execute()
        {
            myTv.ChangeChannel(channel);
        }

        public void UnDo()
        {
            var lastChanel = chanelsWatched.Pop();
            myTv.ChangeChannel(lastChanel);
        }
    }
}
