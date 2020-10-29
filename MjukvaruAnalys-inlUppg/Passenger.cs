using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static MjukvaruAnalys_inlUppg.FoodCart;
using static MjukvaruAnalys_inlUppg.Staff;

namespace MjukvaruAnalys_inlUppg
{
    class Passenger
    {
        public int PassangerID { get; set; }
        public string Name { get; set; }

        public int Age {get;set;}

        public int Money { get; set; }

        public bool HasTicket { get; set; }

        public string SelectDrink { get; set; }

        public Staff drinkServer = new Staff();

      
    


        public Passenger() { }


        public Passenger(int money )
        {
            Money = money;
           

        }



 /*       public Passenger(int money, bool hasTicket)
        {
            Money = money;
            HasTicket = hasTicket;

        }*/








        public void BookTicket() {

            var planeSeats = new AirPlane(3, 1);

            if (planeSeats.CheckSeatAvailabillity() == true)
            {

                var rdnseat = new Random();

                Console.WriteLine("You have now booked a seat.Your seatnumber is " + rdnseat.Next(1,30));
            }
            else
            {

                Console.WriteLine("Booking denied.There are no seats available for this flight");
            }


            }




        

    public void BuyTicket()
        {
            Console.WriteLine("Would you like to buy a ticket?");
            string BuyTicketInput = Console.ReadLine();
            if ((Money >= 100) && (BuyTicketInput.Contains("y")))



            {
                HasTicket = true;
                Console.WriteLine("You have succesfully bought a ticket");
            }


            else if (Money < 100)
            {

                Console.WriteLine("You do not have enough money to buy a ticket");

                return;
            }


            else
            {
                Console.WriteLine("You do not buy a ticket.");

                return;
            }
        }



        public void Board()
        {

            var planeSeats = new AirPlane(3, 1);


            if (planeSeats.CheckSeatAvailabillity() == true)
            {


                if (HasTicket == true)
                {

                    Console.WriteLine("Boarding is permitted");
                }


                else
                {
                    Console.WriteLine("You need a ticket to board");
                    return;
                }

            }


            else
            {
                Console.WriteLine("Boarding not permitted due to overbooking.");

            }
        }


        public void OrderFood() {

            Console.WriteLine("Take your pick(1-4): ");
            string selectedFood = Console.ReadLine();
            var menu = new FoodCart();
         


          
            foreach (FoodItem fooditem in menu.foodMenu)
            {
                if (fooditem.FoodId == selectedFood)
                {

              
                
                            if (fooditem.FoodInStock == "yes") {

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
                        if (AgeCheck().Age >= 18) {

                             Console.WriteLine("You have selected:" + drinkitem.DrinkName);
                            /*
                             drinkServer.ServeDrink();
                             Console.ReadLine();

 */

                            var adult = new Adult();
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



        public Passenger AgeCheck (){

            Console.WriteLine("What is your age?");
            string passangerAge = Console.ReadLine();
            int num = int.Parse(passangerAge);
            if (num >= 18)
            {

                var adult = new Adult
                {
                    Age = num
                };

                return adult;
            }
            else
            {

                var child = new Child();

                child.Age = num;
                return child;
            }
        
        }

    }


   



}
