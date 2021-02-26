using System;
using System.Collections.Generic;
using System.Text;


namespace OOP_Automat
{
    class Logic
    {

        public string ReturnMoneyBack(Machine machine)
        {
            string text = "";
            if (machine.InsertedMoney > machine.Price)
            {
                machine.MoneyReturned = machine.InsertedMoney - machine.Price;
                text = $"You will get {machine.MoneyReturned}";
            }
            return text;
        }

        //Method to select beer, with a switch case
        public void SelectBeer(Machine machine, int userinput)
        {
            switch (userinput)
            {
                case 1:
                    machine.beer.BeersEnum = beers.Tuborg;
                    break;
                case 2:
                    machine.beer.BeersEnum = beers.Carlsberg;
                    break;
                case 3:
                    machine.beer.BeersEnum = beers.RoyalBeer;
                    break;
                default:
                    break;
            }
        }
        public string SelectedBeer(Machine machine)
        {
            string text = "";
            if (machine.beer.BeersEnum == beers.Tuborg)
            {
                machine.Price = machine.beer.GetPrice.TuborgPrice;
                text = $"You have choosen the Tuborg Classic Beer, Cost: {machine.beer.GetPrice.TuborgPrice}";
            }
            else if (machine.beer.BeersEnum == beers.Carlsberg)
            {
                machine.Price = machine.beer.GetPrice.CarlsbergPrice;
                text = $"You have choosen the Carlsberg beer, Cost: {machine.beer.GetPrice.CarlsbergPrice}";
            }
            else if (machine.beer.BeersEnum == beers.RoyalBeer)
            {
                machine.Price = machine.beer.GetPrice.RoyalBeerPrice;
                text = $"You have choosen the Royal Beer, Cost: {machine.beer.GetPrice.RoyalBeerPrice}";
            }
            return text;
        }
        

    }
}
