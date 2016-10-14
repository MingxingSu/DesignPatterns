using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator
{

    /// <summary>
    /// 手机挂件
    /// </summary>
    public class Cover : Decorator
    {
        public Cover(Phone p)
            : base(p)
        {
        }

        public override void AddAccessary()
        {
            base.AddAccessary();//这个很重要，实现了一条action链条


            // 添加新的行为
            AddCover();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddCover()
        {
            Console.WriteLine("Now apple phone has accessaries now");
        }
    }
}
