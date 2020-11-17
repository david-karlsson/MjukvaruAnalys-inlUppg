using System;

namespace MjukvaruAnalys_inlUppg
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
                        var seatcheck = new AirPlane(30, 15);
                        var passengerBoarding = new Passenger(100);
                        Console.WriteLine("There is a total of " + passengerBoarding.planeSeats.Seats + " seats. " + passengerBoarding.planeSeats.OccupiedSeats + " of them are occupied. ");
                        seatcheck.TakeOffCheck();
                        Console.ReadLine();
            */

            var messages = new Messages();

            messages.SeatAvailabilyMessage();


          

       

           
            messages.passengerBoarding.BookTicket();
            messages.passengerBoarding.BuyTicket();
            
            
            
            if(messages.passengerBoarding.Board()== false)
            {
                return;

            }


            if (messages.passengerBoarding.planeSeats.TakeOffCheck() == false)
            {
                return;

            }


            messages.foodMenusPopulate.FoodMenu();
            messages.childOrderingFood.ChildrensMenu();
            messages.FoodOrderingMessage();








            messages.drinkMenusPopulate.DrinkMenu();

            messages.DrinkOrderingMessage();


        }


    }
}
