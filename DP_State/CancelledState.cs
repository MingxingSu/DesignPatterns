using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_State
{
    class CancelledState:State
    {
        public override void Start(Task task)
        {
            throw new NotImplementedException();
        }

        public override void Cancel(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
