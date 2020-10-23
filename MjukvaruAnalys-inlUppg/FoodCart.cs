using System;
using System.Collections.Generic;
using System.Text;

namespace MjukvaruAnalys_inlUppg
{
    class FoodCart
    {
      /*  public string FoodItem { get; set; }*/

        public string Drink { get; set; }


         public class FoodItem
        {
            public string FoodName { get; set; }

            public string FoodInStock { get; set; }

            public string FoodId { get; set; }
        }






        public List<FoodItem>Menu()
        {
            Console.WriteLine("Would you like to see a Food-Menu?");
            string SeeMenu = Console.ReadLine();

            if(SeeMenu == "yes")
            {

                List<FoodItem> menu = new List<FoodItem>();



                menu.Add(new FoodItem() { FoodName="Pasta Bolognese", FoodInStock="yes"});
                menu.Add(new FoodItem() { FoodName = "Lasagna", FoodInStock = "No" });
                menu.Add(new FoodItem() { FoodName = "Roasted Salmon with potato crumpets", FoodInStock = "yes" });
                menu.Add(new FoodItem() { FoodName = "Fish-soup", FoodInStock = "No" });
                foreach (FoodItem fooditem in menu)
                {
                    Console.WriteLine("* " + fooditem.FoodName +" In stock? "+ fooditem.FoodInStock);
                }
              

                return menu;
            }



            else
            {
                List<FoodItem> noMenu = new List<FoodItem>();

                return noMenu;
            }

        }
    }





}
