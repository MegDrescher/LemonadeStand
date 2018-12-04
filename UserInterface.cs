using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
       

    }
    public void DisplayInstructions()
    {
        Console.WriteLine("Hello! What is your name?");
        Console.WriteLine("Welcome to Wisconsin's favorite lemonade stand!");
        Console.WriteLine("Here are the rules to play!");
        Console.WriteLine("Make as much money as you can in seven days! Customers want fresh lemonade! Remember to buy your ingredients daily!");
        Console.WriteLine("Be sure to check the weather daily. Your profits could be affected based on the weather. Be sure to price each cup accordingly.");
        Console.WriteLine("At the end of each day you will be able to see and keep track of your proftis and inventory! Good luck!");
        Console.ReadLine();
        Console.Clear();

    }
}
