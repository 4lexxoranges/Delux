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
    class Lamborghini
    {
        string userInput;
        public int lamborghiniHuracanCount;
        public int lamborghiniHuracanInStockCount = 19;
        public int lamborghiniHuracanPrice = 152000;
        public int lamborghiniHP = 770;
        public int lamborghiniMaxSpeed = 300;
        public int lamborghiniWeight = 1600;
        public void BuyLamborghini()
        {
            Console.Clear();
            Console.WriteLine("Ok, you change Lamborghini");
        }
    }
    class Ferrari
    {
        public int ferrariSpiderCount;
        public int ferrariSpiderInStockCount = 20;
        public int ferrariSpiderPrice = 291000;
        public int ferrariHP = 699;
        public int ferrariMaxSpeed = 260;
        public int ferrariWeight = 1600;
        public void BuyFerrari()
        {
            Console.Clear();
            Console.WriteLine("Ok, you change Ferrari");
        }
    }
    class Koenigsegg
    {
        public int koenigseggAgeraRCount;
        public int koenigseggAgeraRInStockCount = 5;
        public int koenigseggAgeraRPrice = 10000000;
        public int koenigseggHP = 1600;
        public int koenigseggMaxSpeed = 424;
        public int koenigseggWeight = 1600;
        public void BuyKoenigsegg()
        {
            Console.Clear();
            Console.WriteLine("Ok, you change Koenigsegg");
        }
    }
}
