using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWithMonash
{
    public class IFElseClass
    {

        public static void DisplayBasicCode() 
        {
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It'evening.");
            }

            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }

        public static void DisplaySwitchCode() 
        {
            Person person = new Person();

            person.DisplaySpace("First Exercise");
            Console.WriteLine("Enter number ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            if (inputNum >= 1 && inputNum <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("InValid");

            person.DisplaySpace("Second Exercise");

            Console.WriteLine("Enter First number ");
            int FirstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number ");
            int SecondNum = Convert.ToInt32(Console.ReadLine());

            if (FirstNum > SecondNum)
            {
                Console.WriteLine(string.Format("Maximum Number {0}", FirstNum));
            }
            else if (SecondNum > FirstNum)
            {
                Console.WriteLine(string.Format("Maximum Number {0}", SecondNum));
            }
            else { Console.WriteLine("Both number are equal"); }


            person.DisplaySpace("Third Exercise");

            Console.WriteLine("Enter Width of Image ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Height of Image ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Image is Landscape");
            }
            else if (height > width)
            {
                Console.WriteLine("Image is Portrait");
            }
            else
                Console.WriteLine("Image is Normal");


            person.DisplaySpace("Fourth Exercise");

            Console.WriteLine("Enter Speed Limit ");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Speed of Car ");
            int speedCar = int.Parse(Console.ReadLine());

            if (speedCar <= speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int demeritPoints = (speedCar - speedLimit) / 5;
                Console.WriteLine("Demerits Points: " + demeritPoints);

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended.");
                }
            }
        }

    }
}
