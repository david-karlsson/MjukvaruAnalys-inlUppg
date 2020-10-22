using System;
using System.Collections.Generic;
using System.Text;

namespace MjukvaruAnalys_inlUppg
{
    class AirPlane
    {
        public int Seats { get; set; }

        public int OccupiedSeats { get; set; }

        public Array SeatNumbers { get; set; }




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






    }



    
}
