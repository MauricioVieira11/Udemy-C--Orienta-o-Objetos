using System;
using System.Globalization;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2021, 10, 11);
            DateTime d2 = new DateTime(2021, 10,11,15,26,56);

            DateTime d3 = DateTime.Now;
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Parse("2000-02-15 13:05:58");
            DateTime d7 = DateTime.Parse("15/08/2021");
         //   DateTime d8 = DateTime.ParseExact("200-08-15", "yyyy-MM-dd");


            Console.WriteLine("DateTime.Now: "+d1);
            Console.WriteLine("DatetimeTiks: "+d2);
            Console.WriteLine("Datetime: "+d3);
            Console.WriteLine("DateTimeToday: "+d4);
            Console.WriteLine("DatetimeUtcNow: "+d5);
            Console.WriteLine("Datetime.parse: "+d6);
            Console.WriteLine("Datetime.parse: "+d7);
            Console.WriteLine("");



        }
    }
}
