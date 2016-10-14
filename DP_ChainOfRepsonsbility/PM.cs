using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_ChainOfRepsonsbility
{
    class PM:Boss
    {

        public override bool ApproveRequest(Request request)
        {
            int day = request.Days;

            if (day <= 0.5)
            {
                Console.WriteLine("Approved By :" + Name);
                return true;
            }
            return Successor.ApproveRequest(request);

        }

        public PM(string name) : base(name)
        {
        }
    }

    class HR : Boss
    {

        public override bool ApproveRequest(Request request)
        {
            int day = request.Days;

            if ( 0.5 <day  && day <= 2)
            {
                Console.WriteLine("Approved By :" + Name);
                return true;
            }
            return Successor.ApproveRequest(request);

        }

        public HR(string name)
            : base(name)
        {
        }
    }

    class Director : Boss
    {

        public override bool ApproveRequest(Request request)
        {
            int day = request.Days;

            if (day >= 3 && request.Reason.Equals("正当理由"))
            {
                Console.WriteLine("Approved By : " + Name);
                return true;
            }
            return false;//请假批准者的最高领导

        }

        public Director(string name)
            : base(name)
        {
        }
    }
}
