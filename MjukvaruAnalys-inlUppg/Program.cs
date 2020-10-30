using System;

namespace MjukvaruAnalys_inlUppg
{
    class Program
    {
        static void Main(string[] args)
        {
        


           /* var seatcheck = new AirPlane(30,15);*/
            var passengerBoarding = new Passenger(100);
            Console.WriteLine("There is a total of "+ passengerBoarding.planeSeats.Seats+ " seats. " + passengerBoarding.planeSeats.OccupiedSeats+ " of them are occupied. " );
            /*seatcheck.TakeOffCheck();*/
            Console.ReadLine();
           


            if (passengerBoarding.planeSeats.CheckSeatAvailabillity()==true)
            Console.WriteLine("There are seats available for booking.");

            else
            {
                Console.WriteLine("All seats are occupied.");

                return;
            }


       

           
            var menu = new FoodCart();
            passengerBoarding.BookTicket();
            passengerBoarding.BuyTicket();
            passengerBoarding.Board();


            if (passengerBoarding.planeSeats.TakeOffCheck() == false)
            {
                return;

            }



            menu.FoodMenu();
            menu.DrinkMenu();

             Console.WriteLine("Would you like to order some food?");
            string foodorder = Console.ReadLine();

            if (foodorder.Contains("y"))
            {
                menu.OrderFood();
            }
           
            
            Console.WriteLine("Would you like to order a drink?");
            string drinkOrder = Console.ReadLine();
            var totalDrinksOrdered = 0;

            if (drinkOrder.Contains("y") )
            {


                menu.OrderDrink();
                totalDrinksOrdered++;
                
                if(totalDrinksOrdered < 5) { 
                
               
                    
                    
                    Console.WriteLine("Would you like to order another drink?");
                        string moreDrinksOrder = Console.ReadLine();
                    if (moreDrinksOrder.Contains("y")){
                        menu.OrderDrink();
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
                        menu.OrderDrink();
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
                        menu.OrderDrink();
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
                        menu.OrderDrink();
                        totalDrinksOrdered++;
                    }
                    else
                    {
                        return;
                    }



                    Console.WriteLine("Would you like to order another drink?");
                    if (moreDrinksOrder4.Contains("y"))
                    {
                  
                        totalDrinksOrdered++;
                    }



                }


                else if (totalDrinksOrdered == 5)
                {

                    Console.WriteLine("You've had enough to drink. 5 drinks is enough. ");
                    Console.ReadLine();
                }

            }

            else 
            {

                Console.WriteLine("You've had enough to drink. 5 drinks is enough. ");

            }


            


        }


    }
}
