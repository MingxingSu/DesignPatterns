using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder
{
    public  interface IPersonBuilder
    {
        void BuildHead();
        void BuildBody();
        void BuildFoot();

        Person GetPerson();
    }
}
