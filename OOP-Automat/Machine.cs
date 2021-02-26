using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Automat
{
    class Machine
    {
        //Properties
        public Beers beer { get; set; }
        public double MoneyReturned { get; set; }
        public double Price { get; set; }
        public double InsertedMoney { get; set; }

        //Constructor for the machine
        public Machine(int TuborgPrice, int CarlsbergPrice, int RoyalBeerPrice)
        {
            beer = new Beers();
            beer.GetPrice = new Price(TuborgPrice, CarlsbergPrice, RoyalBeerPrice);
        }
    }
}
