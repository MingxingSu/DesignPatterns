using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Iterator
{
    abstract class Container
    {
        public abstract Iterator CreateaIterator();
    }

    class ConcreteContainer: Container
    {
        private IList<object> items = new List<object>(); 

        public int Count()
        {
            return items.Count;
        }

        public override Iterator CreateaIterator()
        {
           return new ConcreteIterator(this);
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index,value); }
        }
    }
}
