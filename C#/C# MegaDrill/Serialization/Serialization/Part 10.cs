using System;
using System.Collections.Generic;
using System.IO; // required
using System.Linq;
using System.Runtime.Serialization; // required
using System.Runtime.Serialization.Formatters.Binary; // required
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{

    // first define a class with the serializable tag, and make sure you are using the required libraries above

    [Serializable]
    class Person
    {
        string name;
        int age;
        string location;

        public Person(string name, int age, string location)
        {
            this.name = name;
            this.age = age;
            this.location = location;
        }

        static void Main(string[] args)
        {
            // then create an instance of that class

            Person Me = new Person("Josh", 24, "San Jose");

            // use a binary formatter and a stream to serialize the instance of the class to a bin file

            IFormatter writeformatter = new BinaryFormatter();
            Stream writestream = new FileStream("SaveMe.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            writeformatter.Serialize(writestream, Me);
            writestream.Close();

            // to deserialize, use another formatter and stream to load the serialized data to a new class instance

            IFormatter readformatter = new BinaryFormatter();
            Stream readstream = new FileStream("SaveMe.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Person MeAgain = (Person)readformatter.Deserialize(readstream);
            readstream.Close();

            // write the details of the deserialized class instance to the console

            Console.WriteLine("Name: {0}, Age: {1}, Location: {2}", MeAgain.name, MeAgain.age, MeAgain.location);


            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
