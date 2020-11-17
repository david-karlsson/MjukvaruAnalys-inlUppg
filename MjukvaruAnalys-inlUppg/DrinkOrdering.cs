using System;
using System.Collections.Generic;
using System.Text;
using static MjukvaruAnalys_inlUppg.FoodCart;


namespace MjukvaruAnalys_inlUppg
{
    class DrinkOrdering
    {



        public void OrderDrink()
        {

            Console.WriteLine("Take your pick(1-6): ");
            string selectedDrink = Console.ReadLine();
            var menu = new FoodCart();

            menu.SelectDrink = selectedDrink;

            foreach (DrinkItem drinkitem in menu.drinkMenu)
            {



                string Idstring = drinkitem.DrinkId.ToString();
                if (Idstring == selectedDrink)
                {



                    if (drinkitem.IsAlcoholic == false)
                    {



                        Console.WriteLine("You have selected:" + drinkitem.DrinkName);
                        menu.drinkServer.ServeFoodOrDrink();


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



            foreach (DrinkItem drinkitem in menu.alcoholicDrinkMenu)
            {



                string Idstring = drinkitem.DrinkId.ToString();
                if (Idstring == selectedDrink)
                {



                    if (drinkitem.IsAlcoholic == false)
                    {



                        Console.WriteLine("You have selected:" + drinkitem.DrinkName);
                        menu.drinkServer.ServeFoodOrDrink();


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
