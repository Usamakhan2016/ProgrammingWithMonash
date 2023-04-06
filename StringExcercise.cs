using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProgrammingWithMonash
{
    public class StringExcercise
    {
        public static void StringExcercisefun()
        {
            Console.Write("Enter a few numbers with hypen\n");
            var input = Console.ReadLine();

            var numbers = new List<int>();

            foreach(var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for(var i =1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i-1] + 1) 
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);

        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
        /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
        /// any duplicates. If so, display "Duplicate" on the console.
        /// </summary>
        public static void StrExc2() 
        {
            Console.WriteLine("Enter few numbers with hyphen");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) 
            {
                return;
            }

            var numbers = new List<int>();
            
            foreach(var number in input.Split("-")) numbers.Add(Convert.ToInt32(number)); numbers.Sort();

            var unique = new List<int>();
            var includeDuplicate = false;

            foreach (var number in numbers) 
            {
                if (!unique.Contains(number)) { unique.Add(number); }
                else { includeDuplicate = true; break; }
            }

            if(includeDuplicate)
            { Console.WriteLine("Duplicates"); }

        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
        /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        public static void StrExc3() 
        {
            Console.WriteLine("Enter time in 24-Hour");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) { Console.WriteLine("Invalid time"); return; }

            var time = input.Split(":");
            if(time.Length != 2) { Console.WriteLine("Invalid time"); return; }

            try 
            {
                var hour = Convert.ToInt32((time[0]));
                var min = Convert.ToInt32((time[1]));

                if(hour >= 0 && hour <= 23 && min >=0 && min <= 59 ) 
                { Console.WriteLine("OK"); }
                else { Console.WriteLine("Invalid time"); }
            }
            catch(Exception) 
            { Console.WriteLine("Invalid time"); }

        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
        /// create a variable name with PascalCase convention. For example, if the user types: 
        /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
        /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
        /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
        /// </summary>b
        public static void StrExc4() 
        {
            Console.WriteLine("Enter few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input)) { Console.WriteLine("Error"); return; }

            var variableName = "";

            foreach(var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);

        }

        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of vowels 
        /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
        /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
        /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
        /// </summary>
        public static void strExc5() 
        {
            Console.WriteLine("Enter a word");
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] {'a','e','o','u','i'}) ;
            var vowelsCount = 0;

            foreach(var Character in input)
            {
                if(vowels.Contains(Character)) vowelsCount++;
            }
            Console.WriteLine(vowelsCount);
        }




    }
}
