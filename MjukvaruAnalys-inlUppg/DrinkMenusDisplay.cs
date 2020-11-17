using System;
using System.Collections.Generic;
using System.Text;

namespace MjukvaruAnalys_inlUppg
{
    class DrinkMenusDisplay
    {

        private FoodCart foodCart = new FoodCart();

        public List<FoodCart.DrinkItem> DrinkMenu()
        {
            Console.WriteLine("Would you like to see a Drink-Menu?");
            string SeeMenu = Console.ReadLine();

            if (SeeMenu.Contains("y"))
            {


                foreach (FoodCart.DrinkItem drinkitem in foodCart.drinkMenu)
                {

                    string alcoholicDisplay = "";

                    if (drinkitem.IsAlcoholic == true)
                    {
                        alcoholicDisplay = "Yes";
                    }

                    else
                    {
                        alcoholicDisplay = "No";

                    }


                    Console.WriteLine("* " + drinkitem.DrinkName + " || Alcoholic? " + alcoholicDisplay);
                }


                var adultDrinker = new Adult();

                Console.WriteLine("**************************");

                adultDrinker.AlcoholicDrinkMenu();

                return foodCart.drinkMenu;
            }



            else
            {
                List<FoodCart.DrinkItem> noMenu = new List<FoodCart.DrinkItem>();

                return noMenu;
            }

        }



    }
}
