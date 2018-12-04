using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player;
        Store store;
        

       
        private Random random = new Random();
        private int dayNumber = 1;
        private readonly int totalDaysInGame;
        public int day;
        private List<Day> days;
        Random rnd = new Random();

        public int minTemperature;
        public int maxTemperature;
        private int cupsPerPitcher;
        private int forecastMultiplier;
        private int temperatureMultiplier;
        public int priceMultiplier;

        public int minIcePerCup { get; private set; }
        public int maxIcePerCup { get; private set; }
        public int minLemonadePricePerCup { get; private set; }
        public int maxLemonadePricePerCup { get; private set; }

        private int minSugarPerCup;
        private int maxSugarPerCup;
        private int minLemonsPerPitcher;
        private int maxLemonsPerPitcher;


        //public int minSugarPricePerCup { get; private set; }
        //public int maxSugarPricePerCup { get; private set; }
        //private int minPrice;
        //private int maxPrice;



        public Game()
        {
            Random random = new Random();
            player = new Player();
            store = new Store();
            totalDaysInGame = 7;
            days = new List<Day>()
            {
                new Day(rnd) {Name = "Monday", Number = 1, weather =new Weather(rnd), report = new Report(player)},
                new Day(rnd) {Name = "Tuesday", Number = 2, weather =new Weather(rnd), report = new Report(player)},
                new Day(rnd) {Name = "Wednesday", Number = 3, weather =new Weather(rnd), report = new Report(player)},
                new Day(rnd) {Name = "Thursday", Number = 4, weather =new Weather(rnd), report = new Report(player)},
                new Day(rnd) {Name = "Friday", Number = 5, weather =new Weather(rnd), report = new Report(player)},
                new Day(rnd) {Name = "Saturday", Number = 6, weather =new Weather(rnd), report = new Report(player)},
                new Day(rnd) {Name = "Sunday", Number = 7, weather =new Weather(rnd), report = new Report(player)},

            };
        }

        public void RunGame()
        {
            store.RunStoreLogic(player);
        }
    } 

}
