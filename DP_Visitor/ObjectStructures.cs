using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Visitor
{

    //对象结构类(ObjectStructure)
    class Blogs
    {
        private IList<Element> blogList = new List<Element>();

        public void AddBlog(Element element)
        {
            blogList.Add(element);
        }

        public void RemoveBlog(Element element)
        {
            blogList.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element e in blogList)
                e.Accept(visitor);
        }
    }
}
