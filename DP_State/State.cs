using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_State
{
    public abstract class State
    {
        public abstract void Start(Task task);

        public abstract void Cancel(Task task);
    }
}
