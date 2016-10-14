using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DP_FactoryMethod
{
    // 在以下情况下，适用于工厂方法模式：

    //(1) 当一个类不知道它所必须创建的对象的类的时候。

    //(2) 当一个类希望由它的子类来指定它所创建的对象的时候。

    //(3) 当类将创建对象的职责委托给多个帮助子类中的某一个，并且你希望将哪一个帮助子类是代理者这一信息局部化的时候。
    public  interface IMessageFactory
    {
        BaseMessage CreateMessage();
        void SendMessage(BaseMessage message);//工厂批发
    }
}
