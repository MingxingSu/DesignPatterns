using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //用户访问blog
            Blogs blogs = new Blogs();
            blogs.AddBlog(new Blog("this is the first blog"));
            blogs.AddBlog(new Blog("this is the second blog"));
            blogs.AddBlog(new Blog("this is the third blog"));
            blogs.AddBlog(new Blog("this is the fourth blog"));

            WebVisitor webVisitor = new WebVisitor();
            WapVisitor mobileWapVisitor = new WapVisitor();

            blogs.Accept(webVisitor);
            blogs.Accept(mobileWapVisitor);

            Console.Read();


            //.net中的应用：

            /*
             * Abstract Element（Node）: Expression
             * Concrete Element: DynamicExpression,NewExpression， MethodCallExpression,NewArrayExpression,GotoExpression,ListInitExpression
             *  Abstract Visitor:ExpressionVisitor
             *  Concreate Visitor:DynamicExpressionVisitor
             *                      virtual Expression VisitDynamic(DynamicExpression node)
             * 
             * 
             */
        }
    }
}
