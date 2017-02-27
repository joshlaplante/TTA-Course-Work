using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegates
{
    delegate void MyDel(string MyString);

    class MCDelegates
    {
        public static void SoLong(string string1)
        {
            Console.WriteLine("So long {0}", string1);
        }

        public static void Farewell(string string2)
        {
            Console.WriteLine("Farewell {0}", string2);
        }

        public static void Adieu(string string3)
        {
            Console.WriteLine("Auf wiedersehen, adieu {0}", string3);
        }



        static void Main(string[] args)
        {
            MyDel Del1, Del2, Del3, MultiDel;

            Del1 = SoLong;
            Del2 = Farewell;
            Del3 = Adieu;

            MultiDel = Del1 + Del2 + Del3;

            Console.WriteLine("Calling Del1: ");
            Del1("!");
            Console.WriteLine("Calling Del2: ");
            Del2("!");
            Console.WriteLine("Calling Del3: ");
            Del3("!");
            Console.WriteLine("Calling MultiDel: ");
            MultiDel("!");


            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
