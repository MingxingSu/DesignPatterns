using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DP_Visitor
{
    public abstract class Visitor
    {
        public abstract void VisitBlog(Element blog);
    }
    //具体访问者(ConcreteVisitor)
    public class WebVisitor : Visitor
    {
        public override void VisitBlog(Element blog)
        {
            Console.WriteLine("Visit Blog via Webpage:" + blog.Name);
        }
    }
    //具体访问者(ConcreteVisitor)
    public class WapVisitor : Visitor
    {
        public override void VisitBlog(Element blog)
        {
            Console.WriteLine("Visit Blog via Mobile:" + blog.Name);

        }
    }
}
