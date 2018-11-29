using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        public int dayNumber;
        public double lemondadePrice;
        public double endOfDayTotal;
        public double people;   
        public int number;
        public Weather weather;
        public List<Customer> customers;
        public Random random;
        public int customersToday;
       



        public object Customers { get; internal set; }


        internal void StartDay()
        {
            throw new NotImplementedException();
        }

        internal void CustomerTransactions(Inventory inventory, Player player)
        {
            throw new NotImplementedException();
        }

        internal void SetUpDay(int index)
        {
            throw new NotImplementedException();
        }




    }

}
