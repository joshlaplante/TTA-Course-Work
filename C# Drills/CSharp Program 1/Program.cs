using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Program_1
{
    public class Program
    {
        //This is where the program starts
        static void Main(string[] args)
        {
            //Prompt user to enter a name
            Console.WriteLine("Enter your name:");

            //Now read the name entered
            string name = Console.ReadLine();

            //Greet the user with entered name
            Console.WriteLine("Hello, " + name);

            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
