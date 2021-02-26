using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Automat
{
    class Menu
    {
        Logic logic = new Logic();
        public void StartMenu()
        {
            Console.WriteLine("Please choose what beer you want");
            Console.WriteLine("1. Tuborg Classic");
            Console.WriteLine("2. Carlsberg");
            Console.WriteLine("3. Royal (blå cola");
        }

        public void MainMenu()
        {
            Machine machine = new Machine(10, 12, 15);
            while (true)
            {
                StartMenu();
                int userinput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                logic.SelectBeer(machine, userinput);
                Console.WriteLine(logic.SelectedBeer(machine));
                Console.WriteLine("Please deposit your money");
                machine.InsertedMoney = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(logic.ReturnMoneyBack(machine));
                Console.ReadLine();

            }
        }
    }
}
