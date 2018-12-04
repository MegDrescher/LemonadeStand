using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        ////member variables
        //public int quantity;
        //public double price;
        //public string typeOfSupply;
        
      
        public List<Lemons> lemon;
        public List<PaperCups> paperCups;
        public List<Sugar> sugar;
        public List<Ice> ice;



      
        public Inventory()
        {
            lemon = new List<Lemons>();
            paperCups = new List<PaperCups>();
            ice = new List<Ice>();
            sugar = new List<Sugar>();

        }
       

    }

   

} //public Inventory(int quantity, double price, string typeOfSupply)
  //{
  //    this.quantity = quantity;
  //    this.price = price;
  //    this.typeOfSupply = typeOfSupply;
  //}
