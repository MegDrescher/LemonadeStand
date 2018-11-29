using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Game myGame = new Game();
        Player player = new Player();
        Inventory inventory = new Inventory();
        Day day = new Day();
        Weather weather = new Weather();
        Recipe recipe = new Recipe();
        BuyFromStore buyFromStore = new BuyFromStore();
        Customer customer = new Customer();
        public int dayNumber = 1;
        public void RunLemonadeStand()
        {
            
            Console.WriteLine("Hello! What is your name?");
            player.name = Console.ReadLine();

            Console.WriteLine("Welcome to Wisconsin's favorite lemonade stand!");
            Console.WriteLine("Here are the rules!");
            Console.WriteLine("Make as much money as you can in seven days! Customers want fresh lemonade! Remember to buy your ingredients daily!");
            Console.WriteLine("Be sure to check the weather daily. Your profits could be affected based on the weather. Be sure to price each cup accordingly.");
            Console.WriteLine("At the end of each day you will be able to see and keep track of your profits and inventory. Good luck!");
            Console.WriteLine("Click Ener to get started!");
            Console.ReadLine();
            Console.Clear();

            
        }
        public void StartGame()
        {
            string condtion = weather.CurrentWeatherCondition();
            int degrees = weather.currentTemperature;
            Console.WriteLine("It is day { } of 7.",dayNumber);
            Console.WriteLine("The weather conditions are: { }. \t Today's temp is:{ } degrees.",condtion, degrees);
            Console.WriteLine("Here is your current inventory.");
            Console.WriteLine("\n Lemons: \t{} \tSugar:\t{} \tIce:\t{}",inventory,inventory.LemonCount,inventory.SugarCount,inventory.IceCount);
            Console.WriteLine("Time to make a trip to the store and buy the ingrediencts for your Lemonade!");
            Console.WriteLine("Press Enter to begin.");
            Console.ReadLine();
            Console.Clear();

            buyFromStore.BuyIngredients(player, inventory);

            day.StartDay();
            day.CustomerTransactions(inventory, player);

        }


    }









}
