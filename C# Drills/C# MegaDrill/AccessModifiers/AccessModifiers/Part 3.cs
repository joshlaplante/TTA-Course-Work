using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class PublicType
    {
        public void PublicPrint()
        {
            Console.WriteLine("Any assembly can access this");
        }
    }

    class ProtectedType
    {
        protected void ProtectedPrint()
        {
            Console.WriteLine("This class and its derived classes can access this");
        }
    }

    class InternalType
    {
        internal void InternalPrint()
        {
            Console.WriteLine("Any class within this assembly can access this");
        }
    }

    class ProtectedInternal
    {
        protected internal void ProtectedInternalPrint()
        {
            Console.WriteLine("Any class within this assembly and any class derived from this class in a different assembly can access this");
        }
    }

    class PrivateType
    {
        private void PrivatePrint()
        {
            Console.WriteLine("Only this class can access this");
        }
    }

}
