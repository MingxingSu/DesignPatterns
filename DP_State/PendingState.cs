using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_State
{
    class PendingState:State
    {
        public override void Start(Task task)
        {
            task.TaskState = new RunningState();
        }

        public override void Cancel(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
