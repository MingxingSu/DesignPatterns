using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Decorator
{
    /// <summary>
    /// 装饰抽象类,要让装饰完全取代抽象组件，所以必须继承自Photo
    /// </summary>
    public abstract class Decorator : Phone
    {
        private Phone phone;

        protected Decorator(Phone p)
        {
            this.phone = p;
        }

        public override void AddAccessary()
        {
            if (phone != null)
            {
                phone.AddAccessary();
            }
        }
    }
}
