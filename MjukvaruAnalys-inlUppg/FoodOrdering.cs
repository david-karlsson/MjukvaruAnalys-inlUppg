using System;
using System.Collections.Generic;
using System.Text;
using static MjukvaruAnalys_inlUppg.FoodCart;

namespace MjukvaruAnalys_inlUppg
{
    class FoodOrdering
    {



        public void OrderFood()
        {

            Console.WriteLine("Take your pick(1-4): ");
            string selectedFood = Console.ReadLine();
            var menu = new FoodCart();




            foreach (FoodItem fooditem in menu.foodMenu)
            {
                if (fooditem.FoodId == selectedFood)
                {



                    if (fooditem.FoodInStock == "yes")
                    {

                        Console.WriteLine("You have selected:" + fooditem.FoodName);
                        menu.drinkServer.ServeFoodOrDrink();

                    }

                    else if (fooditem.FoodInStock == "no")
                    {

                        Console.WriteLine("That item is out of stock");

                        Console.ReadLine();


                    }



                }

                /*
                                else if (selectedFood == null)
                                {
                                    Console.WriteLine("There is no such dish.");
                                    Console.ReadLine();
                                    return;

                                }*/



            }

        }



    }
}
