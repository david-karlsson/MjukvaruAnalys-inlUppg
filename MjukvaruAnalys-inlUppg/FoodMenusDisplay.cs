using System;
using System.Collections.Generic;
using System.Text;

namespace MjukvaruAnalys_inlUppg
{



    class FoodMenusDisplay
    {
        private FoodCart foodCart = new FoodCart();

        public List<FoodCart.FoodItem> FoodMenu()
        {
            Console.WriteLine("Would you like to see a Food-Menu?");
            string SeeMenu = Console.ReadLine();

            if (SeeMenu.Contains("y"))
            {


                foreach (FoodCart.FoodItem fooditem in foodCart.foodMenu)
                {
                    Console.WriteLine("* " + fooditem.FoodName + "||  In stock? " + fooditem.FoodInStock);
                }


                return foodCart.foodMenu;
            }



            else
            {
                List<FoodCart.FoodItem> noMenu = new List<FoodCart.FoodItem>();

                return noMenu;
            }

        }


    }
}
