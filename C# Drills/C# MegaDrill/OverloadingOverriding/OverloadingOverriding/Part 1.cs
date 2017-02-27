using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOverriding
{
    // OVERLOADING

    // overloading is the process of specifying multiple methods with the same name but different parameters, as shown below

    class Adding
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    // when add is called, the number of parameters determines which method is applied.



    // OVERRIDING 

    // overriding is the process of specifying a method in a derived class with the same name as a method in the parent class

    class A
    {
        public virtual void print()
        {
            Console.WriteLine("Parent Class Print Method");
        }

    }

    class B : A
    {
        public override void print()
        {
            Console.WriteLine("Child Class Print Method");
        }
    }

    // if an instance of class B uses the print method, the child class definition overrides the parent class definition

    


    // these methods are tested below
    
    class TestClass
    {
        static void Main(string[] args)
        {
            // overloading example
            Adding AddTest = new Adding();
            Console.WriteLine(AddTest.add(1, 2));
            Console.WriteLine(AddTest.add(1, 2, 3));

            // overriding example
            A ParentTest = new A();
            ParentTest.print();
            B ChildTest = new B();
            ChildTest.print();

            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
