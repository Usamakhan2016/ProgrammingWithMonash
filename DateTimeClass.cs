using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWithMonash
{
    public class DateTimeClass
    {

        public static void DisplayDateTime() 
        {
            //var dateTime = new DateTime(2023,1,1);

            var dateTime = new DateTime();

            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: "+now.Hour);
            Console.WriteLine("Minute: "+now.Minute);


            var tommorrow  = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("Tommorrow: "+tommorrow);
            Console.WriteLine("Yesterday: " + yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd hh:mm:ss"));

            Console.WriteLine("Time Span");

            var timespan = new TimeSpan(1, 2, 3);

            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            Console.WriteLine("Start Time " + start);
            Console.WriteLine("End Time " + end);

            var duration = end - start;

            Console.WriteLine("Duration: "+duration);

            Console.WriteLine("Mintues: " + timespan.Minutes);
            Console.WriteLine("Total Mintues: " + timespan.TotalMinutes);

            Console.WriteLine("Add Example: "+timespan.Add(TimeSpan.FromMinutes(8)));

            Console.WriteLine("Subtract Example: " + timespan.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine("ToString "+timespan.ToString());

            Console.WriteLine("Parse: "+TimeSpan.Parse("01:02:03"));



        }
    }
}
