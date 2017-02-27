using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IExample
    {
        void InterfacePrint();
    }

    class Example : IExample
    {
        void IExample.InterfacePrint()
        {
            Console.WriteLine("Because this class derived from the interface, it must have a void method named InterfacePrint.");
        }
    }

    class TestClass
    {
        static void Main(string[] args)
        {
            IExample TestInterface = new Example();
            TestInterface.InterfacePrint();

            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
