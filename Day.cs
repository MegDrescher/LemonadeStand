using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day 
    {
        public int dayNumber;
        public double lemondadePrice;
        public double endOfDayTotal;
        public double people;   
        public int number;
        public Weather weather;
        public List<Customer> customers;
        Random rnd = new Random();
        public int customersToday;
        public int Number;
        public string Name;

        public Day(Random rnd)
        {
            this.rnd = rnd;
        }

        public object Customers { get; private set; }
        public Report report { get; internal set; }

        public void StartDay()
        {
            


        }

    

    




    }

}
