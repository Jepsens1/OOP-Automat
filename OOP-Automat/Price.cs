using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Automat
{
    class Price
    {
        //Properties
        public double TuborgPrice { get; set; }
        public double CarlsbergPrice { get; set; }
        public double RoyalBeerPrice { get; set; }

        //Constructor
        public Price(int tuborgPrice, int carlsbergPrice, int royalBeerPrice)
        {
            TuborgPrice = tuborgPrice;
            CarlsbergPrice = carlsbergPrice;
            RoyalBeerPrice = royalBeerPrice;
        }
    }
}
