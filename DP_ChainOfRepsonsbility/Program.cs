using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_ChainOfRepsonsbility
{
    class Program
    {
        //职责链是使多个对象都有机会处理请求，从而避免请求的发送者和接受者之间的耦合关系。将这个对象连成一条链，并沿着这条链传递该请求，直到有一个对象处理他为止。
        static void Main(string[] args)
        {
            //解耦请求发出者和处理者，请求发出者不用管处理流程。因为处理流程已经封装在职责链的连接方式里，详细处理又封装在每个人的职责里。
            Boss pm = new PM("PM_Zhang");
            Boss hr = new HR("HR_Lee");
            Boss director = new Director("Director_Zhou");
            pm.Successor = hr;
            hr.Successor = director;

            Request request = new Request(1, "正当理由");
           Console.WriteLine("Approved or not?:"+ hr.ApproveRequest(request));

            request = new Request(2, "正当理由");
            Console.WriteLine("Approved or not?:"+ hr.ApproveRequest(request));

            request = new Request(4, "正当理由");
            Console.WriteLine("Approved or not?:"+ hr.ApproveRequest(request));
            
            request = new Request(8, "不正当理由");
            Console.WriteLine("Approved or not?:" + hr.ApproveRequest(request));

            Console.Read();


            //职责链的缺点

            //让我们继续回到上面的例子，我们发现，其实当请假时间超过2天的时候，PM和HR其实没有做任何的事情，而只是做了一个传递工作。
            //而传递工作之后，他们就成了垃圾对象。也就是说，他们在实际的处理中，并没有发挥任何的作用。那么当这个链结构比较长，比较复杂的话，会产生很多的内存垃圾对象。
        }
    }
}
