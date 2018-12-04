using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Game myGame = new Game();
        

        //Store store = new Store();
        private Random random = new Random();
        public int dayNumber = 1;
        private int daysInGame;
        public int day;

        public int minTemperature;
        public int maxTemperature;
        private int cupsPerPitcher;
        private int forecastMultiplier;
        private int temperatureMultiplier;
        private int priceMultiplier;

        public int minIcePerCup { get; private set; }
        public int maxIcePerCup { get; private set; }
        public int minLemonadePricePerCup { get; private set; }
        public int maxLemonadePricePerCup { get; private set;}

        private int minSugarPerCup;
        private int maxSugarPerCup;
        private int minLemonsPerPitcher;
        private int maxLemonsPerPitcher;
        

        public int minSugarPricePerCup { get; private set; }
        public int maxSugarPricePerCup { get; private set; }
        public int minPrice;
        public int maxPrice;


        //public void RunLemonadeStand();
        public Game()
        {
            Random random = new Random();
            
            //store = new Store(random); 
            temperatureMultiplier =
            forecastMultiplier = 

            minTemperature = 50;
            maxTemperature = 100;
            cupsPerPitcher = 10;
            minIcePerCup = 2;
            maxIcePerCup = 10;
            minLemonadePricePerCup = 1;
            maxLemonadePricePerCup = 10;
            minSugarPerCup = 1;
            maxSugarPerCup = 10;
            minLemonsPerPitcher = 1;
            maxLemonsPerPitcher = 10;
            


        

       
        }
    }
    




    
}
