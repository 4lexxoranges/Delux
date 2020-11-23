using ShopCar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delux
{
    class DillerShop
    {
        Program program = new Program();
        Bank bank = new Bank();
        string userInput;
        public void Delux()
        {

            Console.Clear();
            Console.WriteLine("Welcome. to DillerShop < Delux >!");
            Console.WriteLine("We have Lamborghini Huracan - 102 000$,\nFerrari Spider - 152 000$\nKoenigsegg Agera R - 10 000 000$");
            Console.WriteLine("1 - go to Menu\n2 - buy car");


        }
    }
}
