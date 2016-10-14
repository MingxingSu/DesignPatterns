using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_State
{
    public class Task
    {
        public State TaskState { get; set; }

        public void Start()
        {
            TaskState.Start(this);
        }

        public void Cancel()
        {
            TaskState.Cancel(this);
        }
    }
}
