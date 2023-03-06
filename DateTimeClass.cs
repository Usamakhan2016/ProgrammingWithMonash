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
            var dateTime = new DateTime(2023,1,1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: "+now.Hour);
            Console.WriteLine("Minute: "+now.Minute);


            var tommrrow  = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString);
            Console.WriteLine(now.ToShortDateString);
            Console.WriteLine(now.ToLongTimeString);
            Console.WriteLine(now.ToShortTimeString);

        }
    }
}
