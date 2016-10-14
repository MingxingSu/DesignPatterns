using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_ChainOfRepsonsbility
{
    abstract class Boss
    {
        public string Name { get; set; }

        protected Boss(string name)
        {
            Name = name;
        }

        public Boss Successor { get; set; }//自引用一个Boss类，形成链条的下一个节点，

        public abstract bool ApproveRequest(Request request);//具体节点去实现不同操作
    }
}
