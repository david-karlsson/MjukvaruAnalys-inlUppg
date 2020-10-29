using System;
using System.Collections.Generic;
using System.Text;

namespace MjukvaruAnalys_inlUppg
{
    class FoodCart
    {
      /*  public string FoodItem { get; set; }*/

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



    }





}
