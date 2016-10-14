using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Bridge
{
    public class BusinessObject
    {
        public DataAccess DAL { get; set; }


        public string City { get; set; }

        public BusinessObject(string city)
        {
            this.City = city;
        }

        // 方法
        public virtual void Add(string name)
        {
            DAL.AddRecord(name);
        }
 
        public virtual void Delete(string name)
        {
            DAL.DeleteRecord(name);
        }
 
        public virtual void Update(string name)
        {
            DAL.UpdateRecord(name);
        }
 
        public virtual string Get(int index)
        {
            return DAL.GetRecord(index);
        }
        public virtual void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("{0}'s Customers are：", City);
            DAL.ShowAllRecords();
        }
    }
}
