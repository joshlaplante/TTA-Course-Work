using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Reference
{

    // in C# there are two classifications of data types, value and reference. while a value type is simply allocated in memory,
    // a reference type is allocated in memory but also stores a reference as a pointer to this location. 
    // almost all data types in C# are of the value type, with the exception of strings, which are a reference type.
    // furthermore, classes are a reference type, while structs are a value type. 

    // to illustrate some of the differences of reference and value types, both a class and a struct are defined below, 
    // then instantiated, and methods run that attempt to change their original values. 

    class MyClass
    {
        public MyClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int a { get;  set; }
        public int b { get;  set; }
    }


    struct MyStruct
    {
        public MyStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x { get;  set; }
        public int y { get;  set; }
    }
    

    class TestClass
    {
        static void Main(string[] args)
        {
            MyClass Class1 = new MyClass(1, 2);
            MyStruct Struct1 = new MyStruct(3, 4);

            // the class and struct are both instantiated with original values, and these are displayed in the console

            Console.WriteLine("Class1 Original: a = {0} , b = {1} ", Class1.a.ToString(), Class1.b.ToString());
            Console.WriteLine("Struct1 Original: x = {0} , y = {1} ", Struct1.x.ToString(), Struct1.y.ToString());
            Console.WriteLine();

            // now the ChangeValues method is run, and the values are displayed again. the classes values have been changed,
            // while the structs have not, because the method takes in the class as a reference, creating a new pointer to the same 
            // location in memory as the instantiated class, while the method takes in the struct as a value, 
            // creating an entirely new struct object, and not changing the original struct.

            ChangeValues(Class1, Struct1);

            Console.WriteLine("Class1 After ChangeValues: a = {0} , b = {1} ", Class1.a.ToString(), Class1.b.ToString());
            Console.WriteLine("Struct1 After ChangeValues: x = {0} , y = {1} ", Struct1.x.ToString(), Struct1.y.ToString());
            Console.WriteLine();

            // this time the ChangeValuesRef method is run, and the values are displayed once more. both the values for the class
            // and the struct are changed, because the method takes in the objects both as reference types by using the ref
            // keyword. 

            ChangeValuesRef(ref Class1, ref Struct1);

            Console.WriteLine("Class1 After ChangeValuesRef: a = {0} , b = {1} ", Class1.a.ToString(), Class1.b.ToString());
            Console.WriteLine("Struct1 After ChangeValuesRef: x = {0} , y = {1} ", Struct1.x.ToString(), Struct1.y.ToString());
            Console.WriteLine();

            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }

        static void ChangeValues(MyClass Class, MyStruct Struct)
        {
            Class.a = 11;
            Class.b = 12;

            Struct.x = 13;
            Struct.y = 14;
        }

        static void ChangeValuesRef(ref MyClass Class, ref MyStruct Struct)
        {
            Class.a = 21;
            Class.b = 22;

            Struct.x = 23;
            Struct.y = 24;
        }

    }
}
