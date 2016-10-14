using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Command
{
    class Program
    {
        //命令模式：将请求封装成对象，以便使用不同的请求、日志、队列等来参数化其他对象。命令模式也支持撤销操作。
        static void Main(string[] args)
        {
            //将一组行为抽象为对象，实现二者之间的松耦合。这就是命令模式（Command Pattern）。[1] 


            //Sample
            ICommand command = new ConcreteCommand(new Receiver());
            Invoker invoker = new Invoker();
            invoker.SetCommand(command);
            invoker.RunCommand();
            invoker.CancelCommand();

            //比较容易想起来的例子是：电视遥控器
            //Sample TV:
            Tv tv = new Tv();
            ICommand commandOn = new CommandOn(tv);
            ICommand commandOff = new CommandOff(tv);
            ICommand commandChangeChanel= new CommandChange(tv,2);
            TvControl tvControl = new TvControl();
            tvControl.SetCommand(commandOn);
            tvControl.RunCommand();
            tvControl.UndoCommand();

            tvControl.SetCommand(commandOff);
            tvControl.RunCommand();
            tvControl.UndoCommand();

            tvControl.SetCommand(commandChangeChanel);
            tvControl.RunCommand();
            commandChangeChanel = new CommandChange(tv, 6);
            tvControl.SetCommand(commandChangeChanel);
            tvControl.RunCommand();
            tvControl.UndoCommand();
          

            Console.ReadKey();
        }
    }
}
