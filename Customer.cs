using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public string name;      
        public double customerCash;
        public Store store;
        public readonly Random random = new Random();
        public readonly Day day = new Day();
        public  int temperature;

        public Customer(Random random, Day day)
        {
            this.random = random;
            this.day = day;


        }

        public Customer(Store store)
        {
            this.store = store;
        }
    }
   
    
    
}
