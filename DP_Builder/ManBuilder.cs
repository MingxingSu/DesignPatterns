using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Builder
{
    public class ManBuilder:IPersonBuilder
    {
        private Person _person = null;

        public ManBuilder()
        {
            _person = new Person();
        }

        public void BuildHead()
        {
            _person.Head = "Man's head built";
        }

        public void BuildBody()
        {
            _person.Body = "Man's body built";
        }

        public void BuildFoot()
        {
            _person.Foot = "Man's Foot built";
        }

        public Person GetPerson()
        {
            return _person;
        }
    }
}
