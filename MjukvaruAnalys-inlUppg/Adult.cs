using System;
using System.Collections.Generic;
using System.Text;
using static MjukvaruAnalys_inlUppg.FoodCart;

namespace MjukvaruAnalys_inlUppg
{
    class Adult:Passenger
    {

        FoodCart AdultCart = new FoodCart();




        public List<DrinkItem> AlcoholicDrinkMenu()
        {
          

                foreach (DrinkItem drinkitem in AdultCart.alcoholicDrinkMenu)
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


                    Console.WriteLine("* " + drinkitem.DrinkName + " Alcoholic? " + alcoholicDisplay);
                }


                return AdultCart.alcoholicDrinkMenu;
           



          

        }




        public void OrderAlcoholicDrink()
        {
            /* foreach (DrinkItem drinkitem in drinkMenu)
             {
                 string Idstring = drinkitem.DrinkId.ToString();
                 if (Idstring == SelectDrink)
                 {
                     Console.WriteLine("You have selected:" + drinkitem.DrinkName);
 */
                    var drinkServer = new Staff();
                    drinkServer.ServeFoodOrDrink();
                    Console.ReadLine();
           /*     }
            }*/

        }
    }





}
