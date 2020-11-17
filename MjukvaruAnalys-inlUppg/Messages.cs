using System;
using System.Collections.Generic;
using System.Text;


namespace MjukvaruAnalys_inlUppg
{
    class Messages
    {
        public Passenger passengerBoarding = new Passenger(100);
        public Child childOrderingFood = new Child();
        public FoodCart menu = new FoodCart();
        public FoodMenusDisplay foodMenusPopulate = new FoodMenusDisplay();

        public DrinkMenusDisplay drinkMenusPopulate = new DrinkMenusDisplay();

        private FoodOrdering foodOrdering = new FoodOrdering();

        private DrinkOrdering drinkOrdering = new DrinkOrdering();

        public void SeatAvailabilyMessage()
        {
            Console.WriteLine("There is a total of " + passengerBoarding.planeSeats.Seats + " seats. " + passengerBoarding.planeSeats.OccupiedSeats + " of them are occupied. ");
            /*seatcheck.TakeOffCheck();*/
            Console.ReadLine();


            if (passengerBoarding.planeSeats.CheckSeatAvailabillity() == true)
                Console.WriteLine("There are seats available for booking.");

            else
            {
                Console.WriteLine("All seats are occupied.");

                return;
            }


        }


        public void FoodOrderingMessage()
        {

            Console.WriteLine("Would you like to order some food?");
            string foodorder = Console.ReadLine();

            if (foodorder.Contains("y"))
            {




                Console.WriteLine("Would you like something from the childrens' menu?");
                string childdrensMenuOrder = Console.ReadLine();


                if (childdrensMenuOrder.Contains("y"))
                {



                    childOrderingFood.OrderChildrensMenuFood();
                }

                else
                {
                    foodOrdering.OrderFood();
                }



            }
        }


        public void DrinkOrderingMessage()
        {
            Console.WriteLine("Would you like to order a drink?");
            string drinkOrder = Console.ReadLine();
            var totalDrinksOrdered = 0;

            if (drinkOrder.Contains("y"))
            {


              drinkOrdering.OrderDrink();
                totalDrinksOrdered++;

                if (totalDrinksOrdered < 5)
                {




                    Console.WriteLine("Would you like to order another drink?");
                    string moreDrinksOrder = Console.ReadLine();
                    if (moreDrinksOrder.Contains("y"))
                    {
                        drinkOrdering.OrderDrink();
                        totalDrinksOrdered++;
                    }
                    else
                    {
                        return;
                    }



                    Console.WriteLine("Would you like to order another drink?");
                    string moreDrinksOrder2 = Console.ReadLine();
                    if (moreDrinksOrder2.Contains("y"))
                    {
                        drinkOrdering.OrderDrink();
                        totalDrinksOrdered++;
                    }
                    else
                    {
                        return;
                    }




                    Console.WriteLine("Would you like to order another drink?");
                    string moreDrinksOrder3 = Console.ReadLine();
                    if (moreDrinksOrder3.Contains("y"))
                    {
                        drinkOrdering.OrderDrink();
                        totalDrinksOrdered++;
                    }
                    else
                    {
                        return;
                    }


                    Console.WriteLine("Would you like to order another drink?");
                    string moreDrinksOrder4 = Console.ReadLine();
                    if (moreDrinksOrder4.Contains("y"))
                    {
                        drinkOrdering.OrderDrink();
                        totalDrinksOrdered++;
                    }
                    else
                    {
                        return;
                    }



                    Console.WriteLine("Would you like to order another drink?");
                    string moreDrinksOrder5 = Console.ReadLine();

                    if (moreDrinksOrder5.Contains("y"))
                    {


                        if (totalDrinksOrdered == 5)
                        {

                            Console.WriteLine("You've had enough to drink. 5 drinks is enough. ");
                            Console.ReadLine();
                        }


                    }



                }




            }




        }



    }
}
