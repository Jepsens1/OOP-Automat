using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Automat
{

    //A public enum
    public enum beers
    {
        Tuborg,
        Carlsberg,
        RoyalBeer

    }
    class Beers
    {
        //Properties for beers
        public beers BeersEnum { get; set; }
        public Price GetPrice { get; set; }
    }
}
