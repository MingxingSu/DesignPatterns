using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义：迭代器模式提供一种方法可以顺序访问聚合对象中各个元素，但又不暴露该对象的内部表示。
            ConcreteContainer concreteContainer = new ConcreteContainer();
            Iterator iterator = concreteContainer.CreateaIterator();
            concreteContainer[0] = "Rock";
            concreteContainer[1] = "Max";
            concreteContainer[2] = "Rick";
            concreteContainer[3] = "Eric";
            concreteContainer[4] = "Jack";

            var item = iterator.First();
            while (iterator.IsDone() ==false)
            {
                Console.WriteLine(iterator.CurrentItem().ToString());
                iterator.Next();

            }
            Console.Read();

            //  其实.net框架已经准备好了迭代器接口，只需要实现接口就行了IEumerator 支持对非泛型集合的简单迭代。
            /*      public interface IEnumerable
                    {
                        IEnumerator GetEnumerator();
                    }

                    public interface IEnumertor
                    {

                        public T Current { get; }

                        public bool MoveNext();
                    }
             */


        }
    }


}
