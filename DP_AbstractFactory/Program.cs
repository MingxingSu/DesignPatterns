using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //抽象工厂模式：提供一个创建产品的接口来负责创建相关或依赖的对象，而不具体明确指定具体类

            //抽象工厂对于系列产品的变化支持 “开放——封闭”原则（指的是要求系统对扩展开放，对修改封闭），扩展起来非常简便，
            //但是，抽象工厂对于添加新产品这种情况就不支持”开放——封闭 “原则，这也是抽象工厂的缺点所在,
            //如果需要添加新产品，此时就必须去修改抽象工厂的接口，这样就涉及到抽象工厂类的以及所有子类的改变，这样也就违背了“开发——封闭”原则。

            //抽象工厂，抽象了工厂，方便了开设分厂，连锁店之类的，但是不方便添加新产品。


     

            ///// 扮演抽象工厂的角色
            ///// 创建连接数据库时所需要的对象集合，
            ///// 这个对象集合包括有 DbConnection对象（这个是抽象产品类,如绝味例子中的YaBo类）、DbCommand类、DbDataAdapter类，针对不同的具体工厂都需要实现该抽象类中方法，
            //public abstract class DbProviderFactory
            //{
    
            //// 提供了创建具体产品的接口方法
            //    protected DbProviderFactory();
            //    public virtual DbCommand CreateCommand();
            //    public virtual DbCommandBuilder CreateCommandBuilder();
            //    public virtual DbConnection CreateConnection();
            //    public virtual DbConnectionStringBuilder CreateConnectionStringBuilder();
            //    public virtual DbDataAdapter CreateDataAdapter();
            //    public virtual DbDataSourceEnumerator CreateDataSourceEnumerator();
            //    public virtual DbParameter CreateParameter();
            //    public virtual CodeAccessPermission CreatePermission(PermissionState state);
            //}


            //下面以绝味鸭脖连锁店为例子演示下抽象工厂模式
            //因为每个地方的喜欢的口味不一样，有些地方喜欢辣点的，有些地方喜欢吃不辣点
            //客户端调用
            // 南昌工厂制作南昌的鸭脖和鸭架
            JueWeiAbstractFactory nanChangFactory = new NanChangFactory();
            DuckNeck nanChangDuckNeck = nanChangFactory.CreateDuckNeck();
            nanChangDuckNeck.Print();
            DuckSwings nanChangDuckSwings = nanChangFactory.CreateDuckSwings();
            nanChangDuckSwings.Print();


            // 上海工厂制作上海的鸭脖和鸭架
            JueWeiAbstractFactory shangHaiFactory = new ShangHaiFactory();
            shangHaiFactory.CreateDuckNeck().Print();
            shangHaiFactory.CreateDuckSwings().Print();

            Console.Read();

        }
    }
}


/// <summary>
/// 抽象工厂类，提供创建两个不同地方的鸭架和鸭脖的接口
/// </summary>
public abstract class JueWeiAbstractFactory
{

    // 抽象工厂提供创建一系列产品的接口，这里作为例子，只给出了绝味中鸭脖和鸭架的创建接口
    public abstract DuckNeck CreateDuckNeck();
    public abstract DuckSwings CreateDuckSwings();
}

/// <summary>
/// 南昌绝味工厂负责制作南昌的鸭脖和鸭架
/// </summary>
public class NanChangFactory : JueWeiAbstractFactory
{

    // 制作南昌鸭脖
    public override DuckNeck CreateDuckNeck()
    {
        return new NanChangDuckNeck();
    }

    // 制作南昌鸭架
    public override DuckSwings CreateDuckSwings()
    {
        return new NanChangDuckSwings();
    }
}

/// <summary>
/// 上海绝味工厂负责制作上海的鸭脖和鸭架
/// </summary>
public class ShangHaiFactory : JueWeiAbstractFactory
{

    // 制作上海鸭脖
    public override DuckNeck CreateDuckNeck()
    {
        return new ShangHaiYDuckNeck();
    }

    // 制作上海鸭架
    public override DuckSwings CreateDuckSwings()
    {
        return new ShangHaiDuckSwings();
    }
}

/// <summary>
/// 鸭脖抽象类，供每个地方的鸭脖类继承
/// </summary>
public abstract class DuckNeck
{
    /// <summary>
    /// 打印方法，用于输出信息
    /// </summary>
    public abstract void Print();
}

/// <summary>
/// 鸭架抽象类，供每个地方的鸭架类继承
/// </summary>
public abstract class DuckSwings
{
    /// <summary>
    /// 打印方法，用于输出信息
    /// </summary>
    public abstract void Print();
}

/// <summary>
/// 南昌的鸭脖类，因为江西人喜欢吃辣的，所以南昌的鸭脖稍微会比上海做的辣
/// </summary>
public class NanChangDuckNeck : DuckNeck
{
    public override void Print()
    {
        Console.WriteLine("Duck net from Nanchang");
    }
}

/// <summary>
/// 上海的鸭脖没有南昌的鸭脖做的辣
/// </summary>
public class ShangHaiYDuckNeck : DuckNeck
{
    public override void Print()
    {
        Console.WriteLine("DuckNeck from Shanghai");
    }
}

/// <summary>
/// 南昌的鸭架
/// </summary>
public class NanChangDuckSwings : DuckSwings
{
    public override void Print()
    {
        Console.WriteLine("Duck bone from NanChang");
    }
}

/// <summary>
/// 上海的鸭架
/// </summary>
public class ShangHaiDuckSwings : DuckSwings
{
    public override void Print()
    {
        Console.WriteLine("Done bone from shanghai");
    }
}
