using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge
{
    public class CustomersDataAccess : DataAccess
    {
        // 其实桥接模式就是将高维类的降维处理，
        //将一件事物本征的东西抽象成不同的类，通过不同的类的组合描述一件事物, 其实这与一般的架构设计中要求的模块功能单一化的原则是一致的。
        // 字段
        private List<string> customers = new List<string>();

        public CustomersDataAccess()
        {
            // 实际业务中从数据库中读取数据再填充列表
            customers.Add("Learning Hard");
            customers.Add("Zhang San");
            customers.Add("Li Si");
            customers.Add("Wang Wu");
        }

        // 重写方法
        public override void AddRecord(string name)
        {
            customers.Add(name);
        }

        public override void DeleteRecord(string name)
        {
            customers.Remove(name);
        }

        public override void UpdateRecord(string updatename)
        {
            customers[0] = updatename;
        }

        public override string GetRecord(int index)
        {
            return customers[index];
        }

        public override void ShowAllRecords()
        {
            foreach (string name in customers)
            {
                Console.WriteLine(" " + name);
            }
        }

    }
}
