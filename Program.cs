using ProgrammingWithMonash.Math;
using System;
using System.Text;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;   


namespace ProgrammingWithMonash
{

    class Program
    {
        public enum ShippingMethod 
        {
            RegularAirMail =1,
            RegisteredAirMail =2,
            Express =3
        }

        public enum Season 
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        //public class Person 
        //{
        //    public int Age;
        //}
        static void Main(string[] args)
        {

            Console.WriteLine("          ");
            Console.WriteLine("/********/");
            Console.WriteLine("Enums");


            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            //Parsing is converting string into any other type

            var methodName = "Express";
            var ShippingMethodName = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine("          ");
            Console.WriteLine("/********/");
            Console.WriteLine("Strings");

            var firstName_1 = "Usama";
            var lastName_1 = "Sakhawat";

            var fullName = firstName_1 + " " + lastName_1;
            var myFullName = string.Format("My name is {0} {1}", firstName_1, lastName_1);
            Console.WriteLine(myFullName);

            var names_1= new string[3] { "John", "Marry", "Kate" };
            var formattedNames = string.Join(",", names_1);
            Console.WriteLine(formattedNames);

            //var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";

            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";

            Console.WriteLine(text);

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


            var a_2 = 10;
            var b_2 = a_2;
            b_2++;
            Console.WriteLine(string.Format("a: {0},b: {1}",a_2,b_2));


            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0},array2[0]: {1}", array1[0], array2[0]));


            Console.WriteLine("          ");
            Console.WriteLine("/********/");
            Console.WriteLine("Reference Type");

            var num = 1;
            Increment(num);
            Console.WriteLine(num);

            person.Age = 20;
            MakeOld(person);
            Console.WriteLine(person.Age);

            

            person.DisplaySpace("ForLoop");

            IFElseClass.DisplayBasicCode();
            


            person.DisplaySpace("Switch");

            var season = Season.Autumn;

            switch (season) 
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's autumn and a beautiful season");
                    break;

                default:
                    Console.WriteLine("I don't understand that season!");
                    break;
            }


            IFElseClass.DisplaySwitchCode();


            for (i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            for (i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            var name = "John Smith";

            for (i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }



            foreach (var character_1 in name)
            {
                Console.WriteLine(character_1);
            }

            var newNumbers = new int[] { 0, 1, 2, 3, 4, 5 };

            foreach (var newNumber in newNumbers)
            {
                Console.WriteLine(newNumber);
            }

            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }


            while (true)
            {
                Console.WriteLine("Type Your Name: ");
                var inputName = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(inputName))
                    break;

                Console.WriteLine("@Echo: " + inputName);
            }


            while (true)
            {
                Console.WriteLine("Type Your Name: ");
                var inputName = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(inputName))
                {
                    Console.WriteLine("@Echo: " + inputName);
                    continue;
                }
                break;


            }


            var random = new Random();

            for (var k = 0; k < 10; k++)
            {
                //because a=97 to z=122
                Console.Write((char)('a' + random.Next(0, 26)));
            }
            Console.WriteLine();

            const int passwordLength = 10;
            var buffer = new char[passwordLength];
            for (var k = 0; k < passwordLength; k++)
            {
                //because a=97 to z=122
                buffer[k] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);


            person.DisplaySpace("Loops First Exercise");

            var counter = 0;

            for (var k1 = 1; k1 <= 100; k1++)
            {
                if (k1 % 3 == 0)
                {
                    counter += 1;
                }
            }

            Console.WriteLine(counter);

            person.DisplaySpace("Loops Second Exercise");

            var resultNum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number");
                var inputNumber1 = Console.ReadLine();

                if (inputNumber1 == "ok")
                {
                    break;
                }
                else
                {
                    resultNum += int.Parse(inputNumber1);
                }


            }

            Console.WriteLine(resultNum);


            person.DisplaySpace("Loops Third Exercise");



            Console.WriteLine("Enter a number");
            var factNum = int.Parse(Console.ReadLine());

            Program program = new Program();

            double fact = program.Factorial(factNum);
            Console.WriteLine(factNum + " != " + fact);


            person.DisplaySpace("Loops Fourth Exercise");

            for (var k2 = 1; k2 <= 4; k2++)
            {
                var randNum = random.Next(1, 10);

                Console.WriteLine("Enter Number");
                var userNum = int.Parse(Console.ReadLine());

                if (randNum == userNum)
                {
                    Console.WriteLine("You Won");
                    Console.WriteLine(randNum);
                }
                else
                {
                    Console.WriteLine("You Lost");
                }


            }

            person.DisplaySpace("Loops Fiveth Exercise");

            Console.WriteLine("Enter a series of number,seperated by commas");
            var userInput = Console.ReadLine();
            var userNumArray = userInput.Split(',');

            var numArray = new int[] { 5, 3, 8, 1, 4 };

            var max = Convert.ToInt32(userNumArray[0]);

            foreach (var numArr in userNumArray)
            {
                var numArr1 = Convert.ToInt32(numArr);

                if (numArr1 > max)
                {
                    max = numArr1;
                }
            }

            Console.WriteLine("Max number is " + max);

            person.DisplaySpace("Arrays Concept");

            ArraysClass arraysClass = new ArraysClass();

            arraysClass.ArrayConceptes();

            person.DisplaySpace("Lists");

            ListClass listClass = new ListClass();
            listClass.displayList();

            arraysClass.ArrayExercise();
            arraysClass.secondArrEx();

            arraysClass.thirdArrEx();

            arraysClass.fourthArrEx();

            arraysClass.fifthArrEx();

            DateTimeClass.DisplayDateTime();

            StringClass.displayStringConcepts();

            var sentence = "This is going to be a really really really really really really long text. ";
            var summary = StringClass.SummerizeText(sentence,25);
            Console.WriteLine(summary);

            var builder = new StringBuilder("Hello World");
            builder.AppendLine()
                  .Append('_', 10)
                  .AppendLine()
                  .Append("Header")
                  .AppendLine()
                  .Append('_', 10);

            builder.Replace('_', '+');

            builder.Remove(0,6);
            builder.Insert(0, new string('_', 10));

            Console.WriteLine(builder);
            Console.WriteLine("First Char: " + builder[0]);

            StringExcercise.StringExcercisefun();
            StringExcercise.StrExc2();
            StringExcercise.StrExc3();
            StringExcercise.StrExc4();
            StringExcercise.strExc5();

            // Console.ReadKey();







        }//Main End

        public static void Increment(int number)
        {
            number += 10;

        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;

        }


        public double Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }


    }

   

}

