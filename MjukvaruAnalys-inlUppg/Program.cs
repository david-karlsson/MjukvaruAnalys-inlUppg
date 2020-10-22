using System;

namespace MjukvaruAnalys_inlUppg
{
    class Program
    {
        static void Main(string[] args)
        {
        


            var seatcheck = new AirPlane(30,15);

            Console.WriteLine("There is a total of "+ seatcheck.Seats+ " seats. " + seatcheck.OccupiedSeats+ " of them are occupied. " );

           if (seatcheck.CheckSeatAvailabillity()==true)
            Console.WriteLine("There are seats avilable.");

            else
            {
                Console.WriteLine("All seats are occupied.");
            }


            var passengerBoarding = new Passenger(100,true);

            passengerBoarding.BookTicket();
            passengerBoarding.BuyTicket();
            passengerBoarding.Board();
            

            

        }
    }
}
