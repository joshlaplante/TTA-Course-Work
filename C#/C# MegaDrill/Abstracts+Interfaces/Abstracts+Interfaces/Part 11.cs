using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts_Interfaces
{
    // the main difference between an abstract class and an interface is that an abstract class can be defined with methods, fields, and 
    // properties that have partial or full implementations, while an interface simply states that methods and properties exist, and lets the
    // objects that inherit from the interface define implementation.


    public abstract class AbsPerson
    {

        // fields
        public string FirstName;
        public string LastName;
        public string Occupation;

        // properties
        public abstract string fname
        { get; set; }

        public abstract string lname
        { get; set; }

        public abstract string occ
        { get; set;  }

        // methods
        public string Info()
        {
            return FirstName + " " + LastName + " is a " + Occupation;
        }

    }



    interface IPerson
    {
        // properties
        string fname
        { get; set; }

        string lname
        { get; set; }

        string occ
        { get; set; }

        // methods
        string Info();

    }

    public class PersonFromAbs : AbsPerson
    {
        // fields are inherited here
        public PersonFromAbs()
        {
        }

        // must implement the properties defined in abstract base class
        public override string fname
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public override string lname
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public override string occ
        {
            get
            {
                return Occupation;
            }

            set
            {
                Occupation = value;
            }
        }

        // uses base method for Info
        public new string Info()
        {
            return base.Info();
        }

    }

    public class PersonFromInt : IPerson
    {
        // fields must be define here rather than in the interface definition
        public string FirstName;
        public string LastName;
        public string Occupation;

        // properties laid out in the interface definition are expanded on here
        public string fname
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }

        public string lname
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }

        public string occ
        {
            get
            {
                return Occupation;
            }
            set
            {
                Occupation = value;
            }
        }

        // method mentioned in the interface definition is defined here
        public string Info()
        {
            return FirstName + " " + LastName + " is a " + Occupation;
        }


    }



    class TestClass
    {
        static void Main(string[] args)
        {
            // instances of both the class made from the abstract class and the class made from the interface are created,
            // their properties are set, and their Info method is called

            PersonFromAbs PersonA = new PersonFromAbs();
            PersonA.fname = "Josh";
            PersonA.lname = "La Plante";
            PersonA.occ = "Programmer";
            Console.WriteLine(PersonA.Info());

            PersonFromInt PersonI = new PersonFromInt();
            PersonI.fname = "Josh";
            PersonI.lname = "La Plante";
            PersonI.occ = "Programmer";
            Console.WriteLine(PersonI.Info());

            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
