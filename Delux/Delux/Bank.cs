using System;
using System.Collections.Generic;
using System.Text;

namespace Delux
{
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

}
