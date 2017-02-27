using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorial
{
    class UserInput
    {
        public static void Greeting()
        {
            //prompt user for name
            Console.WriteLine("What is your name?");
            //save inputted name to string
            string name = Console.ReadLine();
            //print greeting with name
            Console.WriteLine("Hello " + name);

           
        }
    }

    class DataExamples
    {
        public static void DataTypes()
        {
            bool canVote = true;

            char grade = 'A';

            //Integer with max value of 2,147,483,647
            int maxInt = int.MaxValue;

            //Long with a max value of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            //Decimal with a max value of 79,228,162,514,264,337,593,543,950,335
            //If bigger is needed, use BigInteger
            decimal maxDec = decimal.MaxValue;

            //Float is a 32 bit number with a max value of 3.402823 E^38 with 7 decimals precision
            float maxFloat = float.MaxValue;

            //Double is a 32 bit number with a max value of 1.797693134 E^308 with 15 decimals precision
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int: " + maxInt);

            var anotherName = "Tom";

            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());
        }
    }

    class MathOperations
    {
        public static void MathExamples()
        {
            Console.WriteLine("5+3= " + (5+3));
            Console.WriteLine("5-3= " + (5-3));
            Console.WriteLine("5*3= " + (5*3));
            Console.WriteLine("5/3= " + (5/3));
            Console.WriteLine("5.2%3= " + (5.2%3));

            int i = 0;

            Console.WriteLine("i++= " + (i++));
            Console.WriteLine("++i= " + (++i));
            Console.WriteLine("i--= " + (i--));
            Console.WriteLine("--i= " + (--i));

            Console.WriteLine("i+=3 " + (i+=3));
            Console.WriteLine("i-=2 " + (i-=2));
            Console.WriteLine("i*=2 " + (i*=2));
            Console.WriteLine("i/=2 " + (i/=2));
            Console.WriteLine("i%=2 " + (i%=2));

        }
    }

    class Casting
    {
        public static void CastingExamples()
        {
            double pi = 3.14;
            int intPi = (int)pi;

            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(number1) " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(number1) " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1) " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(number1,number2) " + (Math.Max(number1,number2)));
            Console.WriteLine("Math.Min(number1) " + (Math.Min(number1,number2)));
            Console.WriteLine("Math.Pow(number1,2) " + (Math.Pow(number1,2)));
            Console.WriteLine("Math.Round(number1) " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(number1) " + (Math.Sqrt(number1)));

            Random rand = new Random();
            Console.WriteLine("Random number between 1 and 10 " + (rand.Next(1, 11)));
        }

        
    }

    class ConditionalExamples
    {
        public static void ConditionalsTernarySwitch()
        {
            // Relational Operators: < > <= >= == !=
            // Logical Operators: && || ^ !

            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14)|| (age >67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true " + (!true));

            bool canDrive = age >= 16 ? true : false;

            switch(age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    goto Cute;
                default:
                    Console.WriteLine("Child");
                    break;
            }
            Cute:
            Console.WriteLine("Toddlers are cute");

        }

        
    }

    class LoopExamples
    {
        public static void Looping()
        {
            int i = 0;

            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue;
                }

                if (i == 9)
                {
                    break;
                }

                if ((i%2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }


            string guess;
            do
            {
                Console.WriteLine("Guess a Number");
                guess = Console.ReadLine();
            } while (!guess.Equals("15"));


            for (int j = 0; j < 10; j++)
            {
                if ((j % 2) > 0)
                {
                    Console.WriteLine(j);
                }
            }


            string randStr = "Aasdfimwkemivis";

            foreach(char c in randStr)
            {
                Console.WriteLine(c);
            }

            

        }

        
    }

    class StringStuff
    {
        public static void StringOperations()
        {
            // escape characters \' \" \\ \b \n \t

            string sampString = "A bunch of random words";

            Console.WriteLine("Is empty: " + String.IsNullOrEmpty(sampString));

            Console.WriteLine("Is empty: " + String.IsNullOrWhiteSpace(sampString));

            Console.WriteLine("String Length: " + sampString.Length);

            Console.WriteLine("Index of bunch: " + sampString.IndexOf("bunch"));

            Console.WriteLine("2nd Word: " + sampString.Substring(2, 6));

            string sampString2 = "More random words";

            Console.WriteLine("Strings Equal: " + sampString.Equals(sampString2));

            Console.WriteLine("Starts with \"A bunch\": " + sampString.StartsWith("A bunch"));

            Console.WriteLine("Ends with \"words\": " + sampString.EndsWith("words"));

            sampString = sampString.Trim(); //can use TrimEnd or TrimStart

            sampString = sampString.Replace("words", "characters");

            sampString = sampString.Remove(0, 2);

            string[] names = new string[3] { "Matt", "Joe", "Paul" };

            Console.WriteLine("Name List: " + String.Join(", ", names));

            //formatting

            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.567, .56, 1000);

            Console.WriteLine(fmtStr);


            //string builder

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1}", "Josh", "A van down by the river.");
            
            // can use Clear to empty the string builder

            sb.Replace("a", "e");
            sb.Remove(5, 7);

            Console.WriteLine(sb.ToString());

        }
    }

    class ArraysListsExamples
    {
        public static void ArraysLists()
        {

            //arrays

            int[] randNumArray;

            int[] randArray = new int[5];

            int[] randArray2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array Length: " + randArray2.Length);

            Console.WriteLine("Item 0: " + randArray2[0]);

            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0}:{1}", i, randArray2[i]);
            }

            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Where is 1: " + Array.IndexOf(randArray2, 1));

            string[] names = { "Tom", "Paul", "Sally" };

            string nameStr = string.Join(", ", names);

            string[] nameArray = nameStr.Split(',');

            int[,] multArray = new int[5, 3];

            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach (int num in multArray2)
            {
                Console.WriteLine(num);
            }

            for (int x = 0; x < multArray2.GetLength(0); x++)
            {
                for (int y = 0; y < multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, y, multArray2[x,y]);
                }
            }

            //lists

            List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(12);
            numList.Add(16);

            int[] randomArray = { 1, 2, 3, 4, 5 };
            numList.AddRange(randomArray);

            //can clear with Clear

            List<int> numList2 = new List<int>(randomArray);

            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            numList.Insert(1, 10);

            numList.Remove(5);

            numList.RemoveAt(2);

            for (int i=0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            Console.WriteLine("4 is in index: " + numList3.IndexOf(4));

            Console.WriteLine("5 in list " + numList.Contains(5));

            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });

            Console.WriteLine("Tom in list " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            strList.Sort();

        }
    }

    class Exceptions
    {
        public static void ExceptionExamples()
        {
            try
            {
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", num, (10 / num));

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                throw new InvalidOperationException("Operation Failed", ex);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        }
    }

    //begin classes, objects...operator overloading

    class AnimalClass
    {

        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public AnimalClass()
        {
            this.height = 0;
            this.weight = 0;
            this.sound = "No Sound";
            this.name = "No Name";
            numOfAnimals++;
        }

        public AnimalClass(double height, double weight, string sound, string name)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }

        public int getSum(int num1 =1, int num2 = 1)
        {
            return num1 + num2;

        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;

        }

        public static void ClassesObjectsEtc()
        {
            AnimalClass spot = new AnimalClass(15, 10, "Woof", "Spot");

            Console.WriteLine("{0} says {1}", spot.name, spot.sound);

            Console.WriteLine("Number of Animals: " + AnimalClass.getNumOfAnimals());

            Console.WriteLine(spot.toString());

            Console.WriteLine(spot.getSum(1.4, 2.7));

            AnimalClass grover = new AnimalClass
            {
                name = "Grover",
                height = 16,
                weight = 18,
                sound = "Grrr"
            };


            Dog spike = new Dog();

            Console.WriteLine(spike.toString());

            spike = new Dog(20, 15, "Grrr", "Spike", "Chicken");

            Console.WriteLine(spike.toString());

            Shape rect = new Rectangle(5, 5);
            Shape tri = new Triangle(5, 5);

            Console.WriteLine("Rect Area: " + rect.area());
            Console.WriteLine("Tri Area: " + tri.area());

            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(5, 5);

            Console.WriteLine("combRect Area: " + combRect.area());
        }



    }

    class Dog : AnimalClass
    {
        public string favFood { get; set; }

        public Dog(): base()
        {
            this.favFood = "No Favorite";
        }

        public Dog(double height, double weight, string sound, string name, string favFood) : base (height, weight, sound, name)
        {
            this.favFood = favFood;
        }

        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
        }

    }


    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }

    public interface ShapeItem
    {
        double area();

    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }

        public static Rectangle operator+ (Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);
        }

    }

    class Triangle : Shape
    {
        private double theBase;
        private double height;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            height = num2;
        }

        public override double area()
        {
            return .5 * (theBase * height);
        }
    }

    //end classes, objects...operator overloading


    //start generics

    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }

        public void showData()
        {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }


    }

    class GenericsExamples
    {
        public static void Examples()
        {
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");

            superman.key = "Superman";
            superman.value = "Clark Kent";

            KeyValue<int, string> SamsungTV = new KeyValue<int, string>(0, "");

            SamsungTV.key = 12345;
            SamsungTV.value = "a 50 inch Samsung TV";

            superman.showData();
            SamsungTV.showData();
        }

    }

    //end generics


    //start enums

    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }

    class EnumExamples
    {
        public static void Examples()
        {
            Temperature micTemp = Temperature.Low;

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;

                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;

                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;

                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }

        }
    
    }

    //end enums


    //start structs

    struct Customers
    {
        private string name;
        private double balance;
        private int id;

        public void createCust(string n, double b, int i)
        {
            name = n;
            balance = b;
            id = i;
        }

        public void showCust()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("ID: " + id);
        }
    }

    class StructExamples
    {
        public static void Examples()
        {
            Customers bob = new Customers();

            bob.createCust("Bob", 15.50, 12345);

            bob.showCust();

        }
    }

    //end structs



    //start delegates


    delegate double GetSum(double num1, double num2);

    class DelegateExamples
    {
        public static void Examples()
        {
            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 = " + sum(5, 10));
        }
    }

    //end delegates



    //start lambdas

    class LambdaExamples
    {
        public static void Examples()
        {
            Func<int, int, int> getSum = (x, y) => x + y;

            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));

            List<int> numList = new List<int> { 5, 10, 15, 20, 25 };

            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();

            foreach(int num in oddNums)
            {
                Console.WriteLine(num + ",");
            }

        }

    }


    //end lambdas


    //start File I/O

    class FileExamples
    {
        public static void Examples()
        {
            string[] custs = new string[] { "Tom", "Paul", "Greg" };

            using (StreamWriter sw = new StreamWriter("custs.txt"))
            {
                foreach (string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }

            string custName = "";
            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }
        }
    }


    //end File I/O




    class TestClass
    {
        static void Main(string[] args)
        {
            //UserInput.Greeting();
            //Data.DataTypes();
            //MathOperations.MathExamples();
            //Casting.CastingExamples();
            //ConditionalExamples.ConditionalsTernarySwitch();
            //LoopExamples.Looping();
            //StringStuff.StringOperations();
            //ArraysListsExamples.ArraysLists();
            //Exceptions.ExceptionExamples();
            //AnimalClass.ClassesObjectsEtc();
            //GenericsExamples.Examples();
            //EnumExamples.Examples();
            //StructExamples.Examples();
            //DelegateExamples.Examples();
            //LambdaExamples.Examples();
            //FileExamples.Examples();

            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();

        }
    }
}
