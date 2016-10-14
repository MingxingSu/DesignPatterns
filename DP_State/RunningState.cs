using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_State
{
    class RunningState:State
    {
        public override void Start(Task task)
        {
            // RunningState执行Start方法转为FinishedState
            task.TaskState = new FinishedState();
        }

        public override void Cancel(Task task)
        {
            // RunningState执行Cancel方法转为CancelledState
            task.TaskState = new CancelledState();
        }
    }
}
