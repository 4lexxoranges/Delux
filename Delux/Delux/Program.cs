using Delux;
using System;

namespace ShopCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            DillerShop dillerShop = new DillerShop();
            string userInput;
            Console.WriteLine("Hi, you play in the real life");
            Console.WriteLine("Go to bank - so that check your balance in bank");
            Console.WriteLine("1 - we go to Bank\n2 - we go to Diller Shop");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                bank.GoToBank();
            }
            if (userInput == "2")
            {
                dillerShop.Delux();
            }
        }
        public void Menu()
        {
            Bank bank = new Bank();
            DillerShop dillerShop = new DillerShop();
            string userInput;
            Console.Clear();
            Console.WriteLine("Hi, again. Where you want to go");
            Console.WriteLine("1 - Go to Bank\n2 - Go to Diller Shop");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                bank.GoToBank();
            }
            if (userInput == "2")
            {
                dillerShop.Delux();
            }
        }
    }
}
