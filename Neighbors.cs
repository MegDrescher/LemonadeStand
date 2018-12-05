using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Neighbors : Customer
    {
        public Neighbors(Store store) : base(store)
        {
            this.store = store;
        }
    }
}
