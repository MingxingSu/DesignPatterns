using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Composite.Structural
{
    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Leaf don't have a child to add");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Leaf don't have a child to be removed");
        }

        public override void Display(int dept)
        {
            Console.WriteLine(Name);
            Console.WriteLine(new String('-', dept) + Name);
        }
    }
}
