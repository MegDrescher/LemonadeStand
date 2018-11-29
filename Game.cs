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
        public Player player = new Player();
        //Store store = new Store();
        Random random = new Random();
        public int dayNumber = 1;
        public int minTemperature;
        public int maxTemperature;

        public int minIcePerCup { get; private set; }
        public int maxIcePerCup { get; private set; }

        public int minPrice;
        public int maxPrice;
        int forecastMultiplier;
        int temperatureMultiplier;
        int priceMultiplier;

        //public void RunLemonadeStand();
        public Game()
        {
            Random random = new Random();
           // player = new List<Player>();
            //store = new Store(random);         
            minTemperature = 50;
            maxTemperature = 100;
            minIcePerCup = 2;
            maxIcePerCup = 10;

       
        }
    }
    




    
}
