using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass
{
    class A
    {
        public void ParentPrint()
        {
            Console.WriteLine("This method is inherited from the parent class");
        }
    }

    class B : A
    {
        public void ChildPrint()
        {
            Console.WriteLine("This method is defined in the child class");
        }
    }

    class TestClass
    {
        static void Main(string[] args)
        {
            B ChildTest = new B();
            ChildTest.ParentPrint();
            ChildTest.ChildPrint();

            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
