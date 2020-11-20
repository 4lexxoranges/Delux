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

    class Bank
    {
        DillerShop dillerShop = new DillerShop();
        Program program = new Program();
        public int moneyUserInBank = 1000000;
        public string userInputBank;
        public string userInputTopUpBalance;
        public string userInputTransferBalance;
        public string userInputTransferBalance2;
        string userID; //user666@gmail.com
        string userPassword; //QWERTY12345
        public void GoToBank()
        {
            Console.Clear();
            Console.WriteLine("Welcome to PrivatBank!");
            Console.WriteLine("What do you want?");
            Console.WriteLine("1 - Log in\n2 - Go back");
            userInputBank = Console.ReadLine();
            switch (userInputBank)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Please, write your gmail, so that Log In, in your account");
                    userID = Console.ReadLine();
                    if (userID == "user666@gmail.com")
                    {
                        Console.WriteLine("Ok. Please, write your password");
                        userPassword = Console.ReadLine();
                        if (userPassword == "QWERTY12345")
                        {
                            Console.WriteLine("You log in account");
                            BankEntrance();
                        }
                        else
                        {
                            Console.WriteLine("Wrong password");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This account does not exist");
                    }
                    break;
                case "2":
                    program.Menu();
                    break;
            }
        }
        public void BankEntrance()
        {
            Console.Clear();
            Console.WriteLine("Congratulations! You in a PrivatBank.");
            Console.WriteLine("What do you want?");
            Console.WriteLine("1 - check your balance\n2 - top up balance\n3 - transfer balance\n4 - go to menu");
            userInputBank = Console.ReadLine();
            switch (userInputBank)
            {
                case "1":
                    Console.WriteLine("Ok, your balance " + moneyUserInBank + "$");
                    Console.WriteLine("Back - back to Bank");
                    userInputBank = Console.ReadLine();
                    if (userInputBank == "Back")
                    {
                        BankEntrance();
                    }
                    break;
                case "2":
                    Console.WriteLine("Ok, how much you want top up balance");
                    userInputTopUpBalance = Console.ReadLine();
                    moneyUserInBank = Convert.ToInt32(userInputTopUpBalance) + moneyUserInBank;
                    Console.Clear();
                    Console.WriteLine("Your balance " + moneyUserInBank + "$");
                    Console.WriteLine("Back - back to Bank");
                    userInputBank = Console.ReadLine();
                    if (userInputBank == "Back")
                    {
                        BankEntrance();
                    }
                    break;
                case "3":
                    Console.WriteLine("Ok, where you want transfer balance?");
                    Console.WriteLine("1 - Another card\n2 - Another phone");
                    userInputBank = Console.ReadLine();
                    if (userInputBank == "1")
                    {
                        Console.WriteLine("Ok, plz write card, where you want transfer your balance?");
                        userInputTransferBalance = Console.ReadLine();
                        if (userInputTransferBalance == "+380675955260")
                        {
                            Console.WriteLine("How much you want transfer balance?");
                            userInputTransferBalance2 = Console.ReadLine();
                            moneyUserInBank = moneyUserInBank - Convert.ToInt32(userInputTransferBalance2);
                            Console.WriteLine("Your balance " + moneyUserInBank + "$");
                            Console.WriteLine("Back - back to Bank");
                            userInputBank = Console.ReadLine();
                            if (userInputBank == "Back")
                            {
                                BankEntrance();
                            }

                        }
                        Console.WriteLine();
                    }
                    else if (userInputBank == "2")
                    {
                        Console.WriteLine("How much you want transfer balance?");
                        userInputTransferBalance2 = Console.ReadLine();
                        moneyUserInBank = moneyUserInBank - Convert.ToInt32(userInputTransferBalance2);
                        Console.WriteLine("Your balance " + moneyUserInBank + "$");
                        Console.WriteLine("Back - back to Bank");
                        userInputBank = Console.ReadLine();
                        if (userInputBank == "Back")
                        {
                            BankEntrance();
                        }
                    }
                    break;
                case "4":
                    program.Menu();
                    break;
            }
        }
    }

    class DillerShop
    {
        Lamborghini lamborghini = new Lamborghini();
        Ferrari ferrari = new Ferrari();
        Koenigsegg koenigsegg = new Koenigsegg();
        Program program = new Program();
        string userInput;
        public void Delux()
        {
            Console.Clear();
            Console.WriteLine("Welcome. to DillerShop < Delux >!");
            Console.WriteLine("We have Lamborghini Huracan - 102 000$,\nFerrari Spider - 152 000$\nKoenigsegg Agera R - 10 000 000$");
            Console.WriteLine("1 - go to Menu\n2 - buy car");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                program.Menu();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("Ok, whats you change?");
                Console.WriteLine("1 - Lambotghini Huracan\n2 - Ferrari Spider\n3 - Koenigsegg Agera R");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        lamborghini.BuyLamborghini();
                        break;
                    case "2":
                        ferrari.BuyFerrari();
                        break;
                    case "3":
                        koenigsegg.BuyKoenigsegg();
                        break;
                }
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
