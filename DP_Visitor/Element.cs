using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Visitor
{
    public abstract class Element
    {
        public string Name { get; set; }
        public abstract void Accept(Visitor visitor);
    }

    public class Blog : Element
    {
        public Blog(string blogName)
        {
            this.Name = blogName;
        }

        public override void Accept(Visitor visitor)
        {
            if (visitor != null)
            {
                visitor.VisitBlog(this);
            }
        }
    }

}
