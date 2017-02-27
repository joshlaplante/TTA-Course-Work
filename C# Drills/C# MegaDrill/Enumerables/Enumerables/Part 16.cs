using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerables
{
    // below is a short example of creating an enumeration and then iterating through it to retreive values and their underlying indices

    class EnumExample
    {
        public enum Runners
        {
            Alex = 1, Ben, Chad, David, Eric
        
        };

        static void Main(string[] args)
        {
            foreach (Runners runner in Enum.GetValues(typeof(Runners)))
            {
                Console.WriteLine(runner + " came in position " + (int)runner);
            }

            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
