using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator
{
    public class Sticker : Decorator
    {
        public Sticker(Phone p) : base(p)
        {
        }

        public override void AddAccessary()
        {
            base.AddAccessary();


            // 添加新的行为
            AddSticker();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddSticker()
        {
            Console.WriteLine("Now apple phone has a sticker");
        }

    }
}
