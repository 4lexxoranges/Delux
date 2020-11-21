using System;
using System.Collections.Generic;
using System.Text;

namespace Delux
{
    class Cars
    {
        public int CarPrice;
        public int CarHP;
        public string CarColor;
        public int CarMaxSpeed;
        public void Lamborghini(int carPrice, int carHp, string carColor, int carMaxSpeed)
        {
            CarPrice = carPrice;
            CarHP = carHp;
            CarColor = carColor;
            CarMaxSpeed = carMaxSpeed;
            carPrice = 102000;
            carHp = 770;
            carMaxSpeed = 250;
        }
        public void Ferrari(int carPrice2, int carHp2, string carColor2, int carMaxSpeed2)
        {
            CarPrice = carPrice2;
            CarHP = carHp2;
            CarColor = carColor2;
            CarMaxSpeed = carMaxSpeed2;
            carPrice2 = 152000;
            carHp2 = 699;
            carMaxSpeed2 = 230;
        }
        public void Koenigsegg(int carPrice3, int carHp3, string carColor3, int carMaxSpeed3)
        {
            CarPrice = carPrice3;
            CarHP = carHp3;
            CarColor = carColor3;
            CarMaxSpeed = carMaxSpeed3;
            carPrice3 = 10000000;
            carHp3 = 1600;
            carMaxSpeed3 = 400;
        }
    }
}
