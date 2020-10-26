using System;
using System.Collections.Generic;
using System.Text;

namespace MjukvaruAnalys_inlUppg
{
    class AirPlane
    {
        public int Seats { get; set; }

        public int OccupiedSeats { get; set; }

        public int SeatNumber { get; set; }




        public AirPlane(int seats,int occupiedSeats){

            Seats = seats;
            OccupiedSeats = occupiedSeats;

        }
            


        public bool CheckSeatAvailabillity()
        {
            if (Seats > OccupiedSeats)
            {
                return true;

            }


            else
            {
                return false;
            }

        }


        public bool TakeOffCheck()
        {
            if (OccupiedSeats < Seats/10)
            {
                Console.WriteLine("Not enough passangers for this flight to take off. Will not fly with less than 10% occupancy.");
                return false;
            }

            else
            {
                return true;
            }


        }



    }



    
}
