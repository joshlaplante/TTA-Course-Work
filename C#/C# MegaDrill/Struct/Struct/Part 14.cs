using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Person
    {
        string name;
        int age;
        string location;

        public Person(string Name, int Age, string Location)
        {
            name = Name;
            age = Age;
            location = Location;
        }

        static void Main(string[] args)
        {
            Person Me = new Person("Josh", 24, "San Jose");

            Console.WriteLine("Hi! My name is {0}. I am {1} years old, and I live in {2}.", Me.name, Me.age, Me.location);


            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
