using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLogging
{
    class ExceptionLogging
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
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Exception logged.");


                using (StreamWriter sw = new StreamWriter("exceptions.txt"))
                {
                    sw.WriteLine(ex.ToString());
                }
            }

            finally
            {
                Console.WriteLine("Remember to never divide by 0!");
            }

        }
    }


    // if the user enters any nonzero number, the try and then the finally blocks will execute, 
    // but if 0 is chosen, the catch block will execute when an exception arises from the try block
    // and then the finally block will execute afterwards. the catch block will log all exception 
    // details to a text file within the bin directory for the project

    class TestClass
    {
        static void Main(string[] args)
        {
            ExceptionLogging.DivideByZero();


            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
