using System;
using Course2.Entities;

namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Check-in date dd/mm/yyyy: ");
            DateTime chechIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Check-out date dd/mm/yyyy: ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if(checkOut <= chechIn)
            {
                Console.WriteLine("Error in reservation: Checkout date must be after ");
            }
            else
            {
                Reservation reservation = new Reservation(number, chechIn, checkOut);
                Console.WriteLine("Reservation: "+ reservation);
                Console.WriteLine();
                Console.WriteLine("Enter data to update reservation: ");
                Console.WriteLine("Check-in date dd/mm/yyyy: ");
                chechIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date dd/mm/yyyy: ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if(chechIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future date. ");
                }
                else if(checkOut <= chechIn)
                {
                    Console.WriteLine("Error in reservation: chekout date must ");
                }
                else
                {
                    reservation.UpdateDates(chechIn, checkOut);
                        Console.WriteLine("reservation: "+ reservation);
                }

            }

        }
    }
}
