using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWithMonash
{
    public class StringClass
    {
        public static void displayStringConcepts() 
        {
            Console.WriteLine("------Strings------");

            var fullName = "Usama Sakhawat ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'",fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0,index);
            var lastName = fullName.Substring(index+1);

            Console.WriteLine("FirstName: "+firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            
            
            

            Console.WriteLine(fullName.Replace("Sakhawat", "Jatoi"));
            Console.WriteLine(fullName.Replace('U', 'O'));
            Console.WriteLine(fullName.Replace(' ', ' '));

            if(String.IsNullOrEmpty(" ".Trim())) 
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine("Age: "+age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));

           

           
        }

        public static string SummerizeText(string sentence,int maxLength = 20) 
        {
            //const int maxLength = 20;

            if (sentence.Length < maxLength)
                return sentence;
                    //Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

           
                
                return String.Join(" ", summaryWords) + "...";

                //Console.WriteLine(summary);

                // sentence.Substring(0, maxLength); 
            }
        }
    }
}
