using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Iterator
{
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract object CurrentItem();
        public abstract bool IsDone();  
    }

    internal class ConcreteIterator:Iterator
    {
        //定义一个具体的聚集对象
        private ConcreteContainer aggregate;

        private int current = 0;

        public ConcreteIterator(ConcreteContainer aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object item = null;
            current ++;
            if (!IsDone())
            {
               item  =  this.aggregate[current];
            }
            return item;
        }

        public override object CurrentItem()
        {
            return this.aggregate[current];
        }

        public override bool IsDone()
        {
            return current >= this.aggregate.Count();
        }
    }
}
