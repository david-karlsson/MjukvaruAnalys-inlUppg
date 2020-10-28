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






        public List<FoodItem>FoodMenu()
        {
            Console.WriteLine("Would you like to see a Food-Menu?");
            string SeeMenu = Console.ReadLine();

            if(SeeMenu.Contains("y"))
            {

                List<FoodItem> foodMenu = new List<FoodItem>();



                foodMenu.Add(new FoodItem() { FoodName="Pasta Bolognese", FoodInStock="yes"});
                foodMenu.Add(new FoodItem() { FoodName = "Lasagna", FoodInStock = "No" });
                foodMenu.Add(new FoodItem() { FoodName = "Roasted Salmon with potato crumpets", FoodInStock = "yes" });
                foodMenu.Add(new FoodItem() { FoodName = "Fish-soup", FoodInStock = "No" });
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


                List<DrinkItem> drinkMenu = new List<DrinkItem>
                {
                    new DrinkItem() { DrinkName = "Lemonade", IsAlcoholic = false},
                    new DrinkItem() { DrinkName = "Vodka Martini", IsAlcoholic = true},
                    new DrinkItem() { DrinkName = "Coffee", IsAlcoholic = false},



                };
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
