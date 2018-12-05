using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Teenagers : Customer
    {
        public Teenagers(Store store) : base(store)
        {
            this.store = store;
        }

    }

    //    public void Teenagers(Random random, Day day)
    //    {

    //    }
    //
}
