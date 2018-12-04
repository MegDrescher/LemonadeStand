using System;
using System.Collections.Generic;

namespace LemonadeStand
{
     public class Store
    {
       public Random random;

        public List<string> bundleTypes { get; private set; }



        //constructor
        public Store(Random random)
        {
            this.random = random;
            List<int> lemonQuantities = new List<int>() { 10, 30, 75 };
            List<int> sugarQuantities = new List<int>() { 10, 20, 30 };
            List<int> iceCubeQuantities = new List<int>() { 100, 250, 500 };
            List<Inventory> lemonBundles = new List<Inventory>();
            List<Inventory> sugarBundles = new List<Inventory>();
            List<Inventory> iceCubeBundles = new List<Inventory>();
            bundleTypes = new List<string>() { "Lemons", "Cups of Sugar", "Ice Cubes" };

        }

        //public void SetSupplyPrice(Player player, List<int> bundleQuantities, List<Inventory> supplyBundleList, int minSupplyPrice, int maxSupplyPrice, int typeIndex)
        //{
        //    {
        //        foreach (int quantity in bundleQuantities)
        //        {
        //            decimal unitDivider = 0;
        //            decimal unitPrice = Decimal.Divide(random.Next(minSupplyPrice, maxSupplyPrice + 1), unitDivider);
        //            double bundlePrice = Math.Round((double)(Decimal.Multiply(unitPrice, quantity)), 2);
        //            Inventory inventory = new Inventory(quantity, bundlePrice, bundleTypes[typeIndex]);
        //            supplyBundleList.Add(Inventory);
        //        }

        //    }
        //}

        public void SellLemons()
        {

        }

        public void SellSugar()
        {

        }

        public void SellIce()
        {

        }

        public void SellCups()
        {

        }





    }
}