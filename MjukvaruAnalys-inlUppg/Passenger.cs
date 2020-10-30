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

         

            if (planeSeats.CheckSeatAvailabillity() == true)
            {

                var rdnseat = new Random();

                Console.WriteLine("You have now booked a seat. Your seatnumber is " + rdnseat.Next(1,30));
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
