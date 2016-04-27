using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder
{
    class Program
    {
        // strings are immutable objects, so every time a change is made to a string you really create a new location in memory for a new string object.
        // if you are constantly changing a string, this can create large overhead. stringbuilders are used to modify strings without creating a new object,
        // but instead changing the current stringbuilder object.

        static void Main(string[] args)
        {

            // here is an example of a stringbuilder object being instantiated

            StringBuilder SB = new StringBuilder("Let's count to 10: ");

            // stringbuilders have different methods and properties than strings do, such as a capacity property that you can use to set the maximum
            // character length of the stringbuilder.

            SB.Capacity = 100;

            // now we will cycle through a loop and modify the stringbuilder object each time, which would be much slower if creating a new 
            // string object every cycle, but is faster with modifying a stringbuilder. we will make use of the append method of stringbuilders to 
            // tack on a new string to the end of the curent stringbuilder object in each cycle. 

            int i = 1;
            while(i<11)
            {
                if (i != 10)
                {
                    SB.Append(i + ", ");
                    i++;
                }
                else
                {
                    SB.Append(i + "!");
                    i++;
                }
            }


            Console.WriteLine(SB);


            // strings have their own methods and properties, most of which differ from the stringbuilder class. here is an example of something you can 
            // do with a string but not a stringbuilder object, we will parse a string to create an integer object from its content.

            string MyString = "0";
            int MyInt = Int32.Parse(MyString);

            Console.WriteLine("MyString is a {0}, with a value of {1}", MyString.GetType(), MyString);
            Console.WriteLine("MyInt is a {0}, with a value of {1}", MyInt.GetType(), MyInt);


            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
            
        }
    }
}
