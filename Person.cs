//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;   

namespace ProgrammingWithMonash
{
    public class Person 
    {
        public string FirstName;
        public string LastName;
        public int Age;


        public void Introduction() 
        {
            Console.WriteLine("My name is "+ FirstName + " " + LastName);
        }

        public void DisplaySpace(string value)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("New Topic: "+ value);
            Console.WriteLine("----------------------------");
        }
    }
}

