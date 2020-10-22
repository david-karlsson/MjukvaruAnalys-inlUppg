using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

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




            public void Board()
        {

            var planeSeats = new AirPlane(3,1); 


            if (planeSeats.CheckSeatAvailabillity() == true){


                if(HasTicket == true) { 

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

    public void BuyTicket()
        {

            if(Money >= 100)
            {

                Console.WriteLine("You have succesfully bought a ticket");
            }


            else
            {

                Console.WriteLine("You do not have enough money to buy a ticket");
            }
        }
    
    
    }


   



}
