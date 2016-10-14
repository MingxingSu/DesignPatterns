using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Composite.Structural
{
    public class Composite:Component
    {
        public Composite(string name) : base(name)
        {
        }

        private List<Component> _children = new List<Component>();
 
        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }

        public override void Display(int dept)
        {
            Console.WriteLine(new String('-', dept) + Name);
            foreach (var c in _children)
            {
                c.Display(dept+2);
            }

        }
    }
}
