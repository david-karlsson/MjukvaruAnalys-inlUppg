using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static MjukvaruAnalys_inlUppg.FoodCart;

namespace MjukvaruAnalys_inlUppg
{
    class Passenger
    {
        public int PassangerID { get; set; }
        public string Name { get; set; }

        public int Age {get;set;}

        public int Money { get; set; }

        public bool HasTicket { get; set; }

        public Passenger() { }


        public Passenger(int money )
        {
            Money = money;
           

        }



        public Passenger(int money, bool hasTicket)
        {
            Money = money;
            HasTicket = hasTicket;

        }


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
            if ((Money >= 100) && (BuyTicketInput =="yes"))



            {
                HasTicket = true;
                Console.WriteLine("You have succesfully bought a ticket");
            }


            else if (Money < 100)
            {

                Console.WriteLine("You do not have enough money to buy a ticket");
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
/*            var menu = new FoodCart.FoodItem();
*/
            List<FoodItem> menu = new List<FoodItem>();

            menu.Add(new FoodItem() { FoodName = "Pasta Bolognese", FoodInStock = "yes" ,FoodId = "1" });
            menu.Add(new FoodItem() { FoodName = "Lasagna", FoodInStock = "no" , FoodId = "2" });
            menu.Add(new FoodItem() { FoodName = "Roasted Salmon with potato crumpets", FoodInStock = "yes", FoodId = "3" });
            menu.Add(new FoodItem() { FoodName = "Fish-soup", FoodInStock = "no", FoodId = "4"});
            foreach (FoodItem fooditem in menu)
            {

                if(fooditem.FoodInStock == "yes") { 

                    if (fooditem.FoodId == selectedFood)

                    Console.WriteLine("You have selected:" + fooditem.FoodName);
                }

                else
                {

                    Console.WriteLine("That item is out of stock");
                }
            }

        }


    }


   



}
