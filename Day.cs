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
        public List<Customer> customers = new List<Customer>();
        public List<Children> children = new List<Children>();
        public List<Adults> adults = new List<Adults>();
        public readonly Day day;

        public List<Neighbors> neighbors = new List<Neighbors>();
        private Random rnd = new Random();
        public int totalCustomers;
        public int Number;
        public string Name;
        private Player player;

        public int totalDaysInGame { get; private set; }

        private List<Day> days;


        public Day()
        {
            day = day;
            rnd = rnd;
            totalCustomers = rnd.Next(20, 100);
            for (int i = 1; i <= totalCustomers; i++)
            {
                customers.Add(new Customer(rnd, this));
            }
        }

        public Day(Random rnd)
        {
            this.rnd = rnd;
        }

        public object Customers { get; internal set; }
        public Report report { get; internal set; }

        public void StartDay()
        {

            totalDaysInGame = 7;
            days = new List<Day>()
                {
                    new Day(rnd) { Name = "Monday", Number = 1, weather = new Weather(rnd), report = new Report(player)},
                    new Day(rnd) { Name = "Tuesday", Number = 2, weather = new Weather(rnd), report = new Report(player)},
                    new Day(rnd) { Name = "Wednesday", Number = 3, weather = new Weather(rnd), report = new Report(player)},
                    new Day(rnd) { Name = "Thursday", Number = 4, weather = new Weather(rnd), report = new Report(player)},
                    new Day(rnd) { Name = "Friday", Number = 5, weather = new Weather(rnd), report = new Report(player)},
                    new Day(rnd) { Name = "Saturday", Number = 6, weather = new Weather(rnd), report = new Report(player)},
                    new Day(rnd) { Name = "Sunday", Number = 7, weather = new Weather(rnd), report = new Report(player)},

                };


        }

    

    




    }

}
