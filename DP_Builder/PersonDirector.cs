using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder
{
    public class PersonDirector
    {
        public Person ConstructPerson(IPersonBuilder personBuilder)
        {
            personBuilder.BuildHead();
            personBuilder.BuildBody();
            personBuilder.BuildFoot();
            return personBuilder.GetPerson();
        }
    }
}
