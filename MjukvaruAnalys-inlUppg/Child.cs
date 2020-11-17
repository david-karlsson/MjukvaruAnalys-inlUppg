using System;
using System.Collections.Generic;
using System.Text;


namespace MjukvaruAnalys_inlUppg
{
    class Child:Passenger
    {
        private readonly FoodCart ChildrensCart  = new FoodCart();





        public List<FoodCart.FoodItem> ChildrensMenu()
        {
            Console.WriteLine("Would you like to see the childrens' Food-Menu?");
            string SeeMenu = Console.ReadLine();

            if (SeeMenu.Contains("y"))
            {


                foreach (FoodCart.FoodItem fooditem in ChildrensCart.childrensMenu)
                {
                    Console.WriteLine("* " + fooditem.FoodName + "||  In stock? " + fooditem.FoodInStock);
                }


                return ChildrensCart.childrensMenu;
            }



            else
            {
                List<FoodCart.FoodItem> noMenu = new List<FoodCart.FoodItem>();

                return noMenu;
            }

        }



        public void OrderChildrensMenuFood()
        {

            var childAge = new Child();


            if(childAge.AgeCheck().Age < 18)
            { 



            Console.WriteLine("Take your pick(1-4): ");
            string selectedFood = Console.ReadLine();




            foreach (FoodCart.FoodItem fooditem in ChildrensCart.childrensMenu)
            {
                if (fooditem.FoodId == selectedFood)
                {



                    if (fooditem.FoodInStock == "yes")
                    {

                        Console.WriteLine("You have selected:" + fooditem.FoodName);
                            ChildrensCart.drinkServer.ServeFoodOrDrink();

                    }

                    else if (fooditem.FoodInStock == "no")
                    {

                        Console.WriteLine("That item is out of stock");

                        Console.ReadLine();


                    }


                      /*  else
                        {
                            Console.WriteLine("There is no such dish.");
                            Console.ReadLine();
                            return;
                        }*/


                    }



                }



            }

            else
            {

                Console.WriteLine("Only children may order from the childrens' menu.");
            }

        }





    }
}
