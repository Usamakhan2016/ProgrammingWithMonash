using ProgrammingWithMonash.Math;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;   


namespace ProgrammingWithMonash
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          ");
            Console.WriteLine("/********/");
            Console.WriteLine("Arrays");

            var number1 = new int[3];
            number1[0] = 1;

            Console.WriteLine(number1[0]);
            Console.WriteLine(number1[1]);
            Console.WriteLine(number1[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"John","Marry","Kate" };
          

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);





            Console.WriteLine("          ");
            Console.WriteLine("/********/");
            Console.WriteLine("Introduction to Classes");

            var person = new Person();
            person.FirstName = "Muhammad";
            person.LastName = "Usama";
            person.Introduction();

            Calculator calculator = new Calculator();
            var result =  calculator.Add(2, 5);
            Console.WriteLine(result);

            

            Console.WriteLine("Welcome Usama Sakhawat");
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;
            var lastName = "Hammadani";
            // const PI = 3.15;

            Console.WriteLine("          ");
            Console.WriteLine("/********/");
            Console.WriteLine("Operators");

            var a_1 = 10;
            var b_1_1 = 3;
            var c_1_1 = 4;

            Console.WriteLine(a_1 / b_1_1);

            Console.WriteLine((float)a_1 / (float)b_1_1);

            Console.WriteLine(c_1_1>b_1_1 && c_1_1 == a_1);



            Console.WriteLine("          ");
            Console.WriteLine("/********/");
            

            //Implicit Conversion
            byte b = 1;
            int i = b;


            //Explicit Conversion
            int a = 1;
            byte c = (byte) a;
            Console.WriteLine("Explicit Conversion");
            Console.WriteLine(c);

            //

            var stringNumber = "12345";
            int iNum = Convert.ToInt32(stringNumber);
            Console.WriteLine(iNum);


            try 
            {
                string str = "true";
                bool b_1 = Convert.ToBoolean(str);
                Console.WriteLine(b_1);

                //var stringNumber_1 = "12345";
                //byte iNum_1 = Convert.ToByte(stringNumber_1);
                //Console.WriteLine(iNum_1);
            }
            catch (Exception) 
            {

                Console.WriteLine("The number could not be converted to a byte.");
             //   throw;
            }

            




            Console.WriteLine("          ");
            Console.WriteLine("/********/");
            Console.WriteLine("Data Types");


            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(lastName);

            Console.WriteLine(i);

            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}

