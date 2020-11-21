using ShopCar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delux
{
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
}
