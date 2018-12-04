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
        private int daysInGame;
        private int day;

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
        }

        public void RunGame()
        {
            store.RunStoreLogic(player);
        }
    } 

}
