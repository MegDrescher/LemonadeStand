using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        //member variables
        public int quantity;
        public double price;
        public string typeOfSupply;
        public List<Supply> lemons;
        public List<Supply> cupsOfSugar;
        public List<Supply> iceCubes;
        public List<Supply> paperCups;





        //constructor
        public Inventory()
        {

        }
        //public Inventory(int quantity, double price, string typeOfSupply)
        //{
        //    this.quantity = quantity;
        //    this.price = price;
        //    this.typeOfSupply = typeOfSupply;
        //}

    }

    public class Supply
    {

    }

}
