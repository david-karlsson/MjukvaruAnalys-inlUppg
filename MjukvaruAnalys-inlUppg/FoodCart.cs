using System;
using System.Collections.Generic;
using System.Text;

namespace MjukvaruAnalys_inlUppg
{
    class FoodCart
    {
        /*  public string FoodItem { get; set; }*/
        public string SelectDrink { get; set; }

        public Staff drinkServer = new Staff();


        public class DrinkItem 
        { 
        
            public int DrinkId { get; set; } 
            public string DrinkName { get; set; }

            public bool IsAlcoholic { get; set; }
        
        }





         public class FoodItem
        {
            public string FoodName { get; set; }

            public string FoodInStock { get; set; }

            public string FoodId { get; set; }
        }


                public List<FoodItem> foodMenu = new List<FoodItem>
                {
                    new FoodItem() { FoodName = "Pasta Bolognese", FoodInStock = "yes", FoodId = "1" },
                    new FoodItem() { FoodName = "Lasagna", FoodInStock = "no", FoodId = "2" },
                    new FoodItem() { FoodName = "Roasted Salmon with potato crumpets", FoodInStock = "yes", FoodId = "3" },
                    new FoodItem() { FoodName = "Fish-soup", FoodInStock = "no", FoodId = "4" }
                };


        public List<DrinkItem> drinkMenu = new List<DrinkItem>
                {
                    new DrinkItem() { DrinkName = "Lemonade", IsAlcoholic = false, DrinkId= 1},
                    new DrinkItem() { DrinkName = "Vodka Martini", IsAlcoholic = true, DrinkId = 2},
                    new DrinkItem() { DrinkName = "Coffee", IsAlcoholic = false, DrinkId = 3},



                };

        public List<FoodItem>FoodMenu()
        {
            Console.WriteLine("Would you like to see a Food-Menu?");
            string SeeMenu = Console.ReadLine();

            if(SeeMenu.Contains("y"))
            {

              
                foreach (FoodItem fooditem in foodMenu)
                {
                    Console.WriteLine("* " + fooditem.FoodName +" In stock? "+ fooditem.FoodInStock);
                }
              

                return foodMenu;
            }



            else
            {
                List<FoodItem> noMenu = new List<FoodItem>();

                return noMenu;
            }

        }



        public List<DrinkItem> DrinkMenu()
        {
            Console.WriteLine("Would you like to see a Drink-Menu?");
            string SeeMenu = Console.ReadLine();

            if (SeeMenu.Contains("y"))
            {


                foreach (DrinkItem drinkitem in drinkMenu)
                {

                    string alcoholicDisplay = "";

                    if (drinkitem.IsAlcoholic== true)
                    {
                         alcoholicDisplay = "Yes"; 
                    }

                    else
                    {
                        alcoholicDisplay = "No";

                    }


                    Console.WriteLine("* " + drinkitem.DrinkName + " Alcoholic? " + alcoholicDisplay);
                }


                return drinkMenu;
            }



            else
            {
                List<DrinkItem> noMenu = new List<DrinkItem>();

                return noMenu;
            }

        }



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
                        drinkServer.ServeFoodOrDrink();

                    }

                    else if (fooditem.FoodInStock == "no")
                    {

                        Console.WriteLine("That item is out of stock");

                        Console.ReadLine();


                    }


                    /*   else
                       {
                           Console.WriteLine("There is no such dish.");
                           Console.ReadLine();

                       }
   */

                }



            }

        }






        public void OrderDrink()
        {

            Console.WriteLine("Take your pick(1-3): ");
            string selectedDrink = Console.ReadLine();
            SelectDrink = selectedDrink;
            var menu = new FoodCart();

            foreach (DrinkItem drinkitem in menu.drinkMenu)
            {



                string Idstring = drinkitem.DrinkId.ToString();
                if (Idstring == selectedDrink)
                {



                    if (drinkitem.IsAlcoholic == false)
                    {



                        Console.WriteLine("You have selected:" + drinkitem.DrinkName);
                        drinkServer.ServeFoodOrDrink();


                    }

                    else if (drinkitem.IsAlcoholic == true)



                    {

                        var adult = new Adult();

                        if (adult.AgeCheck().Age >= 18)
                        {

                            Console.WriteLine("You have selected:" + drinkitem.DrinkName);
                            /*
                             drinkServer.ServeDrink();
                             Console.ReadLine();

 */

                          
                            adult.OrderAlcoholicDrink();
                            return;
                        }


                        else
                        {
                            Console.WriteLine("You need to be an adult in order to alcoholic drinks.");
                            return;
                        }


                    }





                }



            }

        }





    }





}
