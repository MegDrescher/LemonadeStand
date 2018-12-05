using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Adults : Customer
    {
        public Adults(Store store) : base(store)
        {
            this.store = store;


        }
    }

    

}
