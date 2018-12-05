using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        private readonly Player player;
        private readonly Store store;



        private readonly Random random = new Random();
        private readonly int dayNumber = 1;
        private readonly int totalDaysInGame;
        public int day;
        private readonly List<Day> days;
        private readonly Random rnd = new Random();

        public int minTemperature;
        public int maxTemperature;
        private readonly int cupsPerPitcher;
        private readonly int forecastMultiplier;
        private readonly int temperatureMultiplier;
        public int priceMultiplier;

        public int minIcePerCup { get; private set; }
        public int maxIcePerCup { get; private set; }
        public int minLemonadePricePerCup { get; private set; }
        public int maxLemonadePricePerCup { get; private set; }

        private readonly int minSugarPerCup;
        private readonly int maxSugarPerCup;
        private readonly int minLemonsPerPitcher;
        private readonly int maxLemonsPerPitcher;


        //public int minSugarPricePerCup { get; private set; }
        //public int maxSugarPricePerCup { get; private set; }
        //private int minPrice;
        //private int maxPrice;



        public Game()
        {
            Random random = new Random();
            player = new Player();
            store = new Store();
            day = new List<Day>();
            int numberOfDaysToPlay = 7;
        }


    }

    private void RunGame(Player player, Day day)
    {
        {
                Store.RunStoreLogic(player);
        }
    }

}
    

