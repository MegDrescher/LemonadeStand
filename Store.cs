using System;
using System.Collections.Generic;

namespace LemonadeStand
{
    public class Store
    {
        

        public List<string> bundleTypes { get; private set; }
        public Random random;
        public Store()
        {
                           
        }

        private int AskHowManyItems(string item)
        {
            Console.WriteLine($"How many {item} do you want to purchase?");
            int numberOfItems = int.Parse(Console.ReadLine());
            return numberOfItems;
        }

        private void SellLemons(Player player, int numberOfLemons)
        {
            if (player.wallet.cash >= Lemons.price * numberOfLemons)
            {
                for (int i = 0; i < numberOfLemons; i++)
                {
                    Lemons lemon = new Lemons();
                    player.inventory.lemon.Add(lemon);
                    player.wallet.cash -= Lemons.price;
                }
            }
            Console.WriteLine($"You now have {player.inventory.lemon.Count} lemons, and your wallet balance is ${player.wallet.cash}");
        }
        private void SellCups(Player player, int numberOfCups)
        {
            if (player.wallet.cash >= PaperCups.price * numberOfCups)
            {
                for (int i = 0; i < numberOfCups; i++)
                {
                    PaperCups cup = new PaperCups();
                    player.inventory.paperCups.Add(cup);
                    player.wallet.cash -= PaperCups.price;
                }
            }
            Console.WriteLine($"You now have {player.inventory.paperCups.Count} paper cups, and your wallet balance is ${player.wallet.cash}");
        }

        private void SellSugar(Player player, int amountOfSugar)
        {   
            if (player.wallet.cash >= Sugar.price * amountOfSugar)
            {
                for (int i =0; i < amountOfSugar; i++)
                {
                    Sugar sugar = new Sugar();
                    player.inventory.sugar.Add(sugar);
                    player.wallet.cash -= Sugar.price;
                }
            }
            Console.WriteLine($"You now have {player.inventory.sugar.Count} cups of sugar, and your wallet balance is ${player.wallet.cash}");
        }

        private void SellIce(Player player, int amountOfIce)
        {
            if (player.wallet.cash >= Ice.price * amountOfIce)
            {
                for(int i=0; i < amountOfIce; i++)
                {
                    Ice ice = new Ice();
                    player.inventory.ice.Add(ice);
                    player.wallet.cash -= Ice.price;     
                }
            }
            Console.WriteLine($"You now have{player.inventory.ice.Count}  bags of ice, and your wallet balance is ${player.wallet.cash}");
        }
        public void RunStoreLogic(Player player)
        {
            int numberOfLemons = AskHowManyItems("lemons");
            SellLemons(player, numberOfLemons);
            int numberOfCups = AskHowManyItems("paper cups");
            SellCups(player, numberOfCups);
            int amountOfSugar = AskHowManyItems("cups of sugar");
            SellSugar(player, amountOfSugar);
            int numberOfIce = AskHowManyItems("bags of ice");
            SellIce(player, numberOfIce);

        }

    }
}

        //this.random = random;
        //List<int> lemonQuantities = new List<int>() { 10, 30, 75 };
        //List<int> sugarQuantities = new List<int>() { 10, 20, 30 };
        //List<int> paperCupQuantities = new List<int>() { 25, 50, 100 };
        //List<int> iceCubeQuantities = new List<int>() { 100, 250, 500 };
        //List<Inventory> lemonBundles = new List<Inventory>();
        //List<Inventory> sugarBundles = new List<Inventory>();
        //List<Inventory> iceCubeBundles = new List<Inventory>();
        //bundleTypes = new List<string>() { "Lemons", "Cups of Sugar", "Ice Cubes" };








