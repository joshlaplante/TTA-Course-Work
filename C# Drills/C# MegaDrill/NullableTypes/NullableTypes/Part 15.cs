using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{

    // most value types can be defined as nullable when they are first created with a ? after the data type, which allows them to hold a null value.
    // below is an example of using nullable booleans. 

    class NullableExamples
    {
        public static void AskForCoffee(bool? coffee)
        {
            Console.WriteLine("Would you like some coffee?");

            if (coffee == null)
            {
                Console.WriteLine("\tI'm not sure.");
            }

            else if (coffee == true)
            {
                Console.WriteLine("\tCertainly!");
            }

            else if (coffee == false)
            {
                Console.WriteLine("\tNo thanks.");
            }
        }

        static void Main(string[] args)
        {
            bool? coffee1 = null;
            AskForCoffee(coffee1);

            bool? coffee2 = true;
            AskForCoffee(coffee2);

            bool? coffee3 = false;
            AskForCoffee(coffee3);


            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
