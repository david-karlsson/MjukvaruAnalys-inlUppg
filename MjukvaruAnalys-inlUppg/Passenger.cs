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
        public int PassangerId { get; set; }
        public string Name { get; set; }

        public int Age {get;set;}

        public int Money { get; set; }

        public bool HasTicket { get; set; }

     
        public AirPlane planeSeats = new AirPlane(40, 4);


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

            Console.WriteLine("Would you like to book a seat in advance?");
            var seatbooking=Console.ReadLine();

            if (planeSeats.CheckSeatAvailabillity() == true & seatbooking.Contains("y"))
            {

                var rdnseat = new Random();

                Console.WriteLine("You have now booked a seat. Your seatnumber is " + rdnseat.Next(1,30));
            }
            
            
            else if (planeSeats.CheckSeatAvailabillity() == false)
            {

                Console.WriteLine("Booking denied.There are no seats available for this flight");
            }


            else 
            {

                Console.WriteLine("Proceeding without booking a seat.");
                return;
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



        public bool Board()
        {

            


            if (planeSeats.CheckSeatAvailabillity() == true)
            {


                if (HasTicket == true)
                {

                    Console.WriteLine("Boarding is permitted");
                    return true;
                }


                else
                {
                    Console.WriteLine("You need a ticket to board");
                    return false;
                }

            }


            else
            {
                Console.WriteLine("Boarding not permitted due to overbooking.");
                return false;

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
