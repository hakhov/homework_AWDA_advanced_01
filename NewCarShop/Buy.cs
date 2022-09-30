using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCarShop
{
   public  abstract class BuyAction
    {
        public abstract void Buy(int id,List<Car> cars);
    }
}
