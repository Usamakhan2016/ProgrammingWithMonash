//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ProgrammingWithMonash
{
    public class ArraysClass
    {

        public void ArrayConceptes() 
        {
            var numbers = new[] { 3, 7, 8, 6, 5, 10 };

            //Length

            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: "+index);

            //Clear()

            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effects of Clear");


            foreach(var number in numbers) 
            {
                Console.WriteLine(number);
            }

            //Copy()

            int[] anotherArr = new int[3];

            Array.Copy(numbers,anotherArr,3);

            Console.WriteLine("Effects of Copy");


            foreach (var number in anotherArr)
            {
                Console.WriteLine(number);
            }

            //Sort()

            Array.Sort(numbers);

            Console.WriteLine("Effects of Sort");


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            //Reverse()

            Array.Reverse(numbers);

            Console.WriteLine("Effects of Reverse");


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


        }

       public void ArrayExercise() 
        {
           // var count = 0;
            //var Name;

            var list = new List<string>();
            
            while (true) 
            {
                Console.WriteLine("Enter different Name");
                var inputName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputName))
                {
                    break;
                }
                else
                    list.Add(inputName);

                 //count += 1;
               


            }


            switch (list.Count) 
            {
                case 0:
                    Console.WriteLine("Nobody likes your post");
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post", list[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} liked your post", list[0], list[1]);
                    break;
                default:
                    Console.WriteLine("{0} and {1} and {2} other people liked your post", list[0], list[1], (list.Count - 2));
                    break;
            }


            //if(count == 0) 
            //{
            //    Console.WriteLine("No one like your photo");
            //}
            //else if(count == 1) 
            //{
            //    string inputName = null;
            //    Console.WriteLine(inputName +" likes your post.");
            //}
        }


        public void secondArrEx() 
        {
            Console.WriteLine("Enter name");
            var inputName = Console.ReadLine();

            var array = new char[inputName.Length];

            for (var i = inputName.Length; i > 0; i--)
            {

                array[inputName.Length - i] = inputName[i - 1];

                var reversed = new string(array);
                Console.WriteLine("Reversed name: "+reversed);

                //Console.WriteLine(inputName[i-1]);
            }
                

        }

        public void thirdArrEx() 
        {
            
            var list = new List<int>(); 

            while (list.Count < 5) 
            {
                Console.WriteLine("Enter Number");
                var input = int.Parse(Console.ReadLine());

                if (list.Contains(input))
                {
                    Console.WriteLine("Error Number already Exists");
                }
                else
                    list.Add(input);

            }

            Console.WriteLine();

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine("{0} ",item);
            }


        }

        public void fourthArrEx() 
        {

            var list = new List<int>();
            while (true) 
            {
                Console.WriteLine("Enter number");
                var input = Console.ReadLine();

                if (input.CompareTo("Quit") == 0 )
                {
                    break;
                }
                else
                {
                    var number = Convert.ToInt32(input);
                    if (list.Contains(number)) 
                    {
                        continue;
                    }
                    else
                        list.Add(number);
                }
                   


            }

            foreach (var item in list) 
            {
                Console.WriteLine("{0} ",item);
            }

            
        }


        public void fifthArrEx() 
        {
            var list = new List<int>();

            while (true) 
            {
                Console.WriteLine("Enter comma seperate numbers");
                var input = Console.ReadLine();

                var number = input.Split(',');

                if((number.Length == 0) || (number.Length < 5) )
                {
                    Console.WriteLine("Invalid list! Try Again.");
                }
                else 
                {
                    foreach(var item in number) 
                    {
                        list.Add(Convert.ToInt32(item));
                    }
                    break;
                }

            }

            list.Sort();

            for(int i = 0; i < 3; i++) 
            {
                Console.WriteLine("{0} ", list[i]);
            }

           




        }

    }
}
