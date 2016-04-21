using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    class PersonExample
    {
        string name;
        int age;
        string location;

        public PersonExample(string name, int age, string location)
        {
            this.name = name;
            this.age = age;
            this.location = location;
        }


        static void Main(string[] args)
        {
            PersonExample Me = new PersonExample("Josh", 24, "San Jose");
            Console.WriteLine("Name: {0}, Age: {1}, Location: {2}", Me.name, Me.age, Me.location);

            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
