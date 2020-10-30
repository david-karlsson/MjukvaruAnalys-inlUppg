using System;
using System.Collections.Generic;
using System.Text;
using static MjukvaruAnalys_inlUppg.FoodCart;

namespace MjukvaruAnalys_inlUppg
{
    class Adult:Passenger
    {










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
