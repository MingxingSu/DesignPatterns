using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Command
{
    public class Invoker
    {
        private ICommand _command = null;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void RunCommand()
        {
            _command.Execute();
        }

        public void CancelCommand()
        {
            _command.UnDo();
        }
    }

    public class TvControl
    {
        private ICommand _command = null;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void RunCommand()
        {
            _command.Execute();
        }

        public void UndoCommand()
        {
            _command.UnDo();
        }

    }
}
