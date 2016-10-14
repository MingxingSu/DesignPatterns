using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Composite.Structural
{
    public abstract class Component
    {
        protected string Name { get; set; }

        protected Component(string name)
        {
            this.Name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int dept);

    }
}
