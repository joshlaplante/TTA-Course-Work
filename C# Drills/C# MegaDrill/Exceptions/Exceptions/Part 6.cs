using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ExceptionExample
    {
        public static void DivideByZero()
        {
            try
            {
                Console.Write("Divide 5 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("5 / {0} = {1}", num, (5 / num));

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Remember to never divide by 0!");
            }

        }
    }


    // if the user enters any nonzero number, the try and then the finally blocks will execute, 
    // but if 0 is chosen, the catch block will execute when an exception arises from the try block
    // and then the finally block will execute afterwards

    class TestClass
    {
        static void Main(string[] args)
        {
            ExceptionExample.DivideByZero();


            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
