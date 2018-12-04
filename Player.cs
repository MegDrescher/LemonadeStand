using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
       
        public string name;
        public double amountOfMoney = 20;
        public int days = 0;
        public Inventory inventory;
        public Wallet wallet;
        public double startMoneyAmount;
        public double moneyAvailable;
        public double dailyProfit;
        public double dailyExpense;
        public double totalExpense;
        public double totalProfit;
        public Random random;
        public bool notEnoughLemons;
        public bool notEnoughSugar;
        public bool notEnoughIce;
        public bool notEnoughCups;

        public double expenses;
        public double drinkCost;
        public int unpaidCustomers;
        public int numberOfPaidCustomers;
       
       
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            startMoneyAmount = 20;
            moneyAvailable = startMoneyAmount;
            notEnoughCups = true;
            notEnoughLemons = true;
            notEnoughSugar = true;
            notEnoughIce = true;
        }
    }

   



}
