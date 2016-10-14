using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Observer
{
    class Program
    {
        private static void Main(string[] args)
        {
            //观察者模式（Observer）完美的将观察者和被观察的对象分离开。举个例子，用户界面可以作为一个观察者，业务数据是被观察者，用户界面观察业务数据的变化，发现数据变化后，就显示在界面上

            //  观察者模式的组成
            //抽象主题角色：把所有对观察者对象的引用保存在一个集合中，每个抽象主题角色都可以有任意数量的观察者。抽象主题提供一个接口，可以增加和删除观察者角色。一般用一个抽象类和接口来实现。

            //抽象观察者角色：为所有具体的观察者定义一个接口，在得到主题的通知时更新自己。

            //具体主题角色：在具体主题内部状态改变时，给所有登记过的观察者发出通知。具体主题角色通常用一个子类实现。

            //具体观察者角色：该角色实现抽象观察者角色所要求的更新接口，以便使本身的状态与主题的状态相协调。通常用一个子类实现。如果需要，具体观察者角色可以保存一个指向具体主题角色的引用。

            //Sample:物业公司希望设计一个软件，推送小区的消息：快递，小区公共设施维修信息，物品领用，寻物启事。
            BaseMessage waterOffMessage = new WaterOffMessage("本小区1，2号楼停水至明天下午五点");
            ResidentClient residentClient = new ResidentClient();
            residentClient.Name = "SU MINGXING";
            residentClient.RoomNumber = "2-3-304";
            waterOffMessage.AddClient(residentClient);

            ResidentClient residentClient2 = new ResidentClient();
            residentClient.Name = "David L";
            residentClient.RoomNumber = "1-2-305";
            waterOffMessage.AddClient(residentClient2);

            waterOffMessage.SendMessage();

            Console.ReadKey();

        }
    }
}
