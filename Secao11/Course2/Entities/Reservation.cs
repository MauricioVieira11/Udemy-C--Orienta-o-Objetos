using System;
using System.Collections.Generic;
using System.Text;
using Course2.Entities.Exceptions;

namespace Course2.Entities
{
    class Reservation
    {
        public int Roomnumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomnumber, DateTime checkIn, DateTime checkOut) //criação dos construtores
        {
            Roomnumber = roomnumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;

        }
        public void UpdateDates(DateTime checkIn, DateTime checkout)
        {
            CheckIn = checkIn;
            CheckOut = checkout;
        }

        public override string ToString()
        {
            return "Room"
                + Roomnumber
                + ", check-in: "
                + CheckIn.ToString("dd/mm/yyyy")
                +CheckOut.ToString("dd-mm-yyyy")
                +", "
                +Duration()
                +" nights";
        }


    }
}
