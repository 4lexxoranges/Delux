using ShopCar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delux
{
    class DillerShop
    {
        Cars cars = new Cars();
        Program program = new Program();
        string userInput;
        public void Delux()
        {
            Bank bank = new Bank();
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
                        Console.WriteLine("Which color you change");
                        Console.WriteLine("1 - Black\n2 - Red\n3 - Orange");
                        if(userInput == "1")
                        {
                            Console.WriteLine("Ok, you buy Laborghini Aventador, black color, 770HP, Max Speed - 250km/h, weight - 1600kg");
                            bank.moneyUserInBank -= cars.Lamborghini(carPrice);

                        }
                        if (userInput == "2")
                        {
                            Console.WriteLine("Ok, you buy Laborghini Aventador, red color, 770HP, Max Speed - 250km/h, weight - 1600kg");
                            bank.moneyUserInBank -= cars.Lamborghini();
                        }
                        if (userInput == "3")
                        {
                            Console.WriteLine("Ok, you buy Laborghini Aventador, orange color, 770HP, Max Speed - 250km/h, weight - 1600kg");

                        }

                        break; 
                    case "2":
                        Console.WriteLine("Which color you change");
                        if (userInput == "1")
                        {
                            Console.WriteLine("Ok, you buy Ferrari Spider, black color, 699HP, Max Speed - 230km/h, weight - 1600kg");

                        }
                        if (userInput == "2")
                        {
                            Console.WriteLine("Ok, you buy Ferrari Spider, red color, 669HP, Max Speed - 230km/h, weight - 1600kg");

                        }
                        if (userInput == "3")
                        {
                            Console.WriteLine("Ok, you buy Ferrari Spider, yellow color, 669HP, Max Speed - 230km/h, weight - 1600kg");

                        }
                        break;
                    case "3":
                        Console.WriteLine("Which color you change");
                        if (userInput == "1")
                        {
                            Console.WriteLine("Ok, you buy Koenigegg Agera R, black color, 1600HP, Max Speed - 400km/h, weight - 1600kg");
                            
                        }
                        if (userInput == "2")
                        {
                            Console.WriteLine("Ok, you buy Koenigegg Agera R, red color, 1600HP, Max Speed - 400km/h, weight - 1600kg");
                        }
                        if (userInput == "3")
                        {
                            Console.WriteLine("Ok, you buy Koenigegg Agera R, white color, 1600HP, Max Speed - 400km/h, weight - 1600kg");
                        }
                        break;
                }
            }
        }
    }
}
