using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_ChainOfRepsonsbility
{
    internal class Request
    {
        public Request(int day, string reason)
        {
            Days = day;
            Reason = reason;
        }

        public string Reason { get; set; }
        public int Days { get; set; }
    }

}
