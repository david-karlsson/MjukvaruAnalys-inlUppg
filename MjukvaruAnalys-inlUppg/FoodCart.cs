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


        public List<FoodItem> childrensMenu = new List<FoodItem>
                {
                    new FoodItem() { FoodName = "Pasta Bolognese(Small portion)", FoodInStock = "yes", FoodId = "1" },
                    new FoodItem() { FoodName = "Lasagna(Small portion)", FoodInStock = "yes", FoodId = "2" },
                    new FoodItem() { FoodName = "Pancakes with strawberry jam", FoodInStock = "no", FoodId = "3" },
                    new FoodItem() { FoodName = "Meatballs(Small portion)", FoodInStock = "yes", FoodId = "4" }
                };



        public List<DrinkItem> drinkMenu = new List<DrinkItem>
                {
                    new DrinkItem() { DrinkName = "Lemonade", IsAlcoholic = false, DrinkId= 1},
                    new DrinkItem() { DrinkName = "Sparkling water", IsAlcoholic = false, DrinkId = 2},
                    new DrinkItem() { DrinkName = "Coffee", IsAlcoholic = false, DrinkId = 3},



                };



        public List<DrinkItem> alcoholicDrinkMenu = new List<DrinkItem>
                {
                    new DrinkItem() { DrinkName = "Bloody Mary", IsAlcoholic = true, DrinkId= 4},
                    new DrinkItem() { DrinkName = "Vodka Martini", IsAlcoholic = true, DrinkId = 5},
                    new DrinkItem() { DrinkName = "Whiskey", IsAlcoholic = true, DrinkId = 6},



                };





















      





    }





}
