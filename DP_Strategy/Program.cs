using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            //该模式涉及到三个角色：

            //* 环境角色（Context）：持有一个Strategy类的引用
            //* 抽象策略角色（Strategy）：这是一个抽象角色，通常由一个接口或抽象类来实现。此角色给出所有具体策略类所需实现的接口。
            //* 具体策略角色（ConcreteStrategy）：包装了相关算法或行为。
            CompanyStrategy companyStrategy = new CompanyStrategy();
            TaxCounterContext taxCounter = new TaxCounterContext(companyStrategy);
            taxCounter.CollectionTax(12000);

            PersonalTaxStrategy personalTaxStrategy = new PersonalTaxStrategy();
            taxCounter = new TaxCounterContext(personalTaxStrategy);
            taxCounter.CollectionTax(14657);

            Console.ReadKey();

        }
    }
}
