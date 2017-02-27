using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Drills
{

    // 1. variables and data types


    public class AgePrinter
    {

        public static void PrintAge()
        {
            int Age = 25;
            Console.WriteLine("My age is {0}", Age);
        }
    }

    public class StarPrinter
    {
        public static void PrintStars()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("*****");
                Console.WriteLine();
            }
        }
    }

    public class randomData
    {
        public static void printData()
        {
            int x = 10;
            float y = 12.5f;
            string str = "C# Programming";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(str);
        }
    }

    public class NamePrinter
    {
        public static void PrintName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", name);
        }
    }


    // 2. operations


    public class SomeOperations
    {
        public static void PrintStuff()
        {
            int x = 10;
            int y = 5;

            Console.WriteLine("x value \t y value \t Expressions \t Result");
            Console.WriteLine("{0,-8} \t {1,-8} \t x=y+3 \t\t x={2,-8}", x, y, y + 3);
            Console.WriteLine("{0,-8} \t {1,-8} \t x=y-2 \t\t x={2,-8}", x, y, y - 2);
            Console.WriteLine("{0,-8} \t {1,-8} \t x=y*5 \t\t x={2,-8}", x, y, y * 5);
            Console.WriteLine("{0,-8} \t {1,-8} \t x=x/y \t\t x={2,-8}", x, y, x / y);
            Console.WriteLine("{0,-8} \t {1,-8} \t x=x%y \t\t x={2,-8}", x, y, x % y);

        }
    }

    public class MoreOperations
    {
        public static void PrintStuff()
        {
            int x = 10;
            int y = 5;

            Console.WriteLine("x value \t y value \t Expressions \t Result");
            Console.WriteLine("{0,-8} \t {1,-8} \t x+=y \t\t x={2,-8}", x, y, x + y);
            Console.WriteLine("{0,-8} \t {1,-8} \t x-=y-2 \t x={2,-8}", x, y, x - y + 2);
            Console.WriteLine("{0,-8} \t {1,-8} \t x*=y*5 \t x={2,-8}", x, y, x * y * 5);
            Console.WriteLine("{0,-8} \t {1,-8} \t x=x/y \t\t x={2,-8}", x, y, x / (x / y));
            Console.WriteLine("{0,-8} \t {1,-8} \t x%=y \t\t x={2,-8}", x, y, x % y);
        }
    }

    public class UserInteger
    {
        public static void PrintStuff()
        {
            int x;
            int y;

            Console.Write("Enter a value:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of x is {0}", x);
            y = ++x;
            Console.WriteLine("The value of ++x is {0}", y);
            Console.WriteLine("The value of x is {0}", x);
            y = x++;
            Console.WriteLine("The value of x++ is {0}", y);
            Console.WriteLine("The value of x is {0}", x);
            y = --x;
            Console.WriteLine("The value of --x is {0}", y);
            Console.WriteLine("The value of x is {0}", x);
            y = x--;
            Console.WriteLine("The value of x-- is {0}", y);
            Console.WriteLine("The value of x is {0}", x);
        }
    }


    // 3. conditionals: if/else

    public class GreatestValue
    {
        public static void FindGreatest()
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Enter x value: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y value: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter z value: ");
            z = int.Parse(Console.ReadLine());

            if(x>y && x>z)
            {
                Console.WriteLine("x is the greatest");
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("y is the greatest");
            }
            else
            {
                Console.WriteLine("z is the greatest");
            }

        }
    }

    public class GradeFinder
    {
        public static void FindGrade()
        {
            int quiz;
            int midterm;
            int final;

            Console.WriteLine("Enter quiz value: ");
            quiz = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter midterm value: ");
            midterm = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter final value: ");
            final = int.Parse(Console.ReadLine());

            float avg = (quiz + midterm + final) / 3;
            if (avg >= 90)
            {
                Console.WriteLine("Grade = A");
            }
            else if (avg < 90 && avg >= 70)
            {
                Console.WriteLine("Grade = B");
            }
            else if (avg < 70 && avg >= 50)
            {
                Console.WriteLine("Grade = C");
            }
            else
            {
                Console.WriteLine("Grade = F");
            }
        }
    }


    // 4. conditionals: switch case

    public class KeyPressCheck
    {
        public static void CheckKey()
        {
            char key;
            Console.WriteLine("Press a number key:");
            key = (char)Console.Read();
            switch (key)
            {
                case '0': Console.WriteLine("You pressed 0"); break;
                case '1': Console.WriteLine("You pressed 1"); break;
                case '2': Console.WriteLine("You pressed 2"); break;
                case '3': Console.WriteLine("You pressed 3"); break;
                case '4': Console.WriteLine("You pressed 4"); break;
                case '5': Console.WriteLine("You pressed 5"); break;
                case '6': Console.WriteLine("You pressed 6"); break;
                case '7': Console.WriteLine("You pressed 7"); break;
                case '8': Console.WriteLine("You pressed 8"); break;
                case '9': Console.WriteLine("You pressed 9"); break;
                default: Console.WriteLine("Not allowed!"); break;

            }

        }
    }

    public class Quiz
    {
        public static void Question()
        {
            Console.WriteLine("What is the correct way to declare a variable to store an integer value in C#?");
            Console.WriteLine("a. int 1x = 10");
            Console.WriteLine("b. int x = 10");
            Console.WriteLine("c. float x = 10.0f");
            Console.WriteLine("d. string x = \"10\"");
            Console.WriteLine("Choose the answer letter: ");
            char ans = (char)Console.Read();
            switch (ans)
            {
                case 'a': Console.WriteLine("Nope!"); break;
                case 'b': Console.WriteLine("Yup!"); break;
                case 'c': Console.WriteLine("Nope!"); break;
                case 'd': Console.WriteLine("Nope!"); break;
                default: Console.WriteLine("That's not an answer!"); break;


            }
        }
    }


    // 5. loops: for


    public class DiminishingStars
    {
        public static void PrintStars()
        {
            string str = "*";
            for(int i = 7; i>0; i--)
            {
                for(int j = 1; j<=i; j++)
                {
                    Console.Write(str);
                }
                Console.WriteLine();
            }
        }
    }


    public class NumsAndStars
    {
        public static void PrintIt()
        {
            string str = "*";
            for(int i = 1; i<8; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for (int k = 7-i; k>0; k--)
                {
                    Console.Write(str);
                }
                Console.WriteLine();
            }
                
        }
    }



    // 6. loops: while


    public class AnotherQuiz
    {
        public static void Question()
        {
            string answer;
            string loop = "y";
            Console.WriteLine("What is the command keyword to exit a loop in C#?");
            Console.WriteLine("a. quit");
            Console.WriteLine("b. continue");
            Console.WriteLine("c. break");
            Console.WriteLine("d. exit");

            while (loop == "y")
            {
                Console.WriteLine("Enter your answer: ");
                answer = Console.ReadLine();

                if (answer == "c")
                {
                    Console.WriteLine("Yup!"); break;
                }
                else
                {
                    Console.WriteLine("Nope!");
                    Console.WriteLine("Want to try again? Enter 'y' to continue, enter 'q' to quit");
                    loop = Console.ReadLine();
                }
                
            }
        }
    }


    public class ASCIIPrinter
    {
        public static void PrintIt()
        {
            int num = 1;
            while(num<122)
            {
                Console.Write((char)num);
                num++;
                if(num%10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }


    // 7. loops: do while

    public class AnotherQuiz2
    {
        public static void Question()
        {
            string answer;
            string loop = "y";
            Console.WriteLine("What is the command keyword to exit a loop in C#?");
            Console.WriteLine("a. quit");
            Console.WriteLine("b. continue");
            Console.WriteLine("c. break");
            Console.WriteLine("d. exit");

            do
            {
                Console.WriteLine("Enter your answer: ");
                answer = Console.ReadLine();

                if (answer == "c")
                {
                    Console.WriteLine("Yup!"); break;
                }
                else
                {
                    Console.WriteLine("Nope!");
                    Console.WriteLine("Want to try again? Enter 'y' to continue, enter 'q' to quit");
                    loop = Console.ReadLine();
                }

            } while (loop == "y");
        }
    }


    public class ASCIIPrinter2
    {
        public static void PrintIt()
        {
            int num = 1;
            do
            {
                Console.Write((char)num);
                num++;
                if (num % 10 == 0)
                {
                    Console.WriteLine();
                }
            } while (num < 122);
        }
    }


    // 8. random numbers

    public class NumberGame
    {
        public static void RandomNum()
        {
            Random randnum = new Random();
            int randint;
            randint = randnum.Next(1, 11);
            int guess;
            Console.WriteLine("Enter a number from 1 to 10");
            guess = Console.Read();
            if (randint == guess)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose! The number was {0}", randint);
            }
        }
    }

    public class NumberGame2
    {
        public static void RandomNum()
        {
            Random randnum = new Random();
            int randint;
            randint = randnum.Next(1, 11);
            int guess;
            string loop = "y";
            while (loop == "y")
            {
                Console.WriteLine("Enter a number from 1 to 10");
                guess = int.Parse(Console.ReadLine());

                if (randint == guess)
                {
                    Console.WriteLine("You win!"); break;
                }
                else
                {
                    Console.WriteLine("Nope! Want to guess again? Enter 'y' to keep playing, or 'n' to stop");
                    loop = Console.ReadLine();
                }
            }
           
        }
    }



    // 9. arrays: sorting

    
    public class BubbleSorter
    {
        public static void BubbleAsc()
        {
            int[] nums = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 } ;
            for (int i = 1 ; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length - 1; j++ )
                {
                    if (nums[j] > nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            for(int k = 0; k < nums.Length; k++)
            {
                Console.WriteLine(nums[k]);
            }
            
        }

        public static void BubbleDesc()
        {
            int[] nums = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 };
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] < nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            for (int k = 0; k < nums.Length; k++)
            {
                Console.WriteLine(nums[k]);
            }
        }
    }


    // 10. arrays: searching

    public class SequentialSearch
    {
        public static void FindIt()
        {
            int[] nums = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 };
            Console.WriteLine("The array contains the following elements: ");
            for (int i = 0; i < nums.Length;i++)
            {
                Console.Write(nums[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Enter the number you would like to find: ");
            string numstring = Console.ReadLine();
            int num = int.Parse(numstring);
            bool found = false;
            for (int i = 0; i< nums.Length; i++)
            {
                if (nums[i] == num)
                {
                    found = true;
                    int pos = i;
                    Console.WriteLine("Your number, {0}, was found at position {1}", num, pos);
                    break;
                }
            }
            if(found == false)
            {
                Console.WriteLine("Your number is not in the array");
            }
        }
    }

    public class BinarySearch
    {
        public static void FindIt()
        {
            int[] nums = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 };
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("The array contains the following elements: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + ",");
            }

            Console.WriteLine();
            Console.WriteLine("Enter the number you would like to find: ");
            string numstring = Console.ReadLine();
            int num = int.Parse(numstring);

            int start = 0;
            int end = nums.Length - 1;
            bool found = false;
            int pos = 0;
            while (start <= end && found == false)
            {
                int middle = (start + end) / 2;
                if (nums[middle] == num)
                {
                    pos = middle;
                    found = true;
                }
                else
                {
                    if (num < nums[middle])
                    {
                        end = middle - 1;
                    }
                    else
                    {
                        start = middle + 1;
                    }
                }
            }

            if (found == true)
            {
                Console.WriteLine("Your number, {0}, was found at position {1}", num, pos);
            }
            else
            {
                Console.WriteLine("Your number is not in the array.");
            }
        }
    }


    // 11. arrays: print series of numbers


    public class Array2d
    {
        public static void PrintIt()
        {
            int[,] array = new int[5, 5];

            int num = 1;
            for (int row = 0; row<5; row++)
            {
                for (int col = 0; col<5; col++)
                {
                    array[row, col] = num;
                    num += 1;
                }
            }

            for (int row = 0; row<5; row++)
            {
                for (int col = 0; col<5; col++)
                {
                    Console.Write(array[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }


    // 12. arrays: matrix printing

    public class Matrix
    {
        public static void PrintIt()
        {
            int[,] array = new int[5, 5];

            for(int row = 0; row < 5; row++)
            {
                for (int col = 0; col<5; col++)
                {
                    if (row == col)
                    {
                        array[row, col] = 0;
                    }
                    else if (row < col)
                    {
                        array[row, col] = 1;
                    }
                    else
                    {
                        array[row, col] = -1;
                    }
                }
            }

            for (int row = 0; row< 5; row++)
            {
                for (int col = 0; col< 5; col++)
                {
                    Console.Write(array[row,col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }


    // 13. arrays: pascal's triangle


    public class PTriangle
    {
        public static void PrintIt()
        {
            int[,] PTriangle = new int[5, 5];
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    PTriangle[row, col] = 0;
                }
            }
            PTriangle[0, 0] = 1;
            PTriangle[1, 0] = 1;
            PTriangle[1, 1] = 1;

            for (int row = 2; row < 5; row++)
            {
                PTriangle[row, 0] = 1;
                for (int col = 1; col <= row; col++)
                {
                    PTriangle[row, col] = PTriangle[row - 1, col - 1] + PTriangle[row - 1, col];
                }
            }

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(PTriangle[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }


    // 14. arrays: statistics

    
    public class StatsStuff
    {
        public static void DoTheMath()
        {
            float mean, median, sd;
            int mode = 0;
            Console.WriteLine("How many numbers will you enter in your data set?");
            string numstring = Console.ReadLine();
            int numOfNums = int.Parse(numstring);
            if(numOfNums < 3)
            {
                Console.WriteLine("You need more numbers in your data set, fool.");
            }
            else
            {
                int[] data = new int[numOfNums];
                int i = 0;
                for(i = 0; i < numOfNums; i++)
                {
                    Console.WriteLine("Number {0}: ", i+1);
                    string datastring = Console.ReadLine();
                    data[i] = int.Parse(datastring);
                }

                for (int j = 1; j < data.Length; j++)
                {
                    for (int k = 0; k < data.Length - 1; k++)
                    {
                        if (data[k] > data[k + 1])
                        {
                            int temp = data[k];
                            data[k] = data[k + 1];
                            data[k + 1] = temp;
                        }
                    }
                }

                int sum = 0;
                for (int a = 0; a < data.Length; a++)
                {
                    sum += data[a];
                }
                mean = (float)sum / data.Length;

                if (data.Length % 2 == 1)
                {
                    median = data[numOfNums / 2];
                }
                else
                {
                    median = (data[numOfNums / 2] + data[numOfNums / 2 + 1]) / 2;
                }

                int[,] modeArray = new int[numOfNums, 2];
                for(int b = 0; b < data.Length; b++)
                {
                    modeArray[b, 0] = data[b];
                    int count = 0;
                    for (int c = 0; c < data.Length; c++)
                    {
                        if (data[b] == data[c])
                        {
                            count += 1;
                        }
                    }
                    modeArray[b, 1] = count;
                }
                int max = 1;
                for(int d = 0; d < modeArray.GetLength(0); d++)
                {
                    if(modeArray[d,1] > max)
                    {
                        max = modeArray[d, 1];
                        mode = modeArray[d, 0];
                    }
                }

                float deviation = 0;
                float sumdev = 0f;
                float variance = 0;
                for (int e = 0; e < data.Length; e++)
                {
                    deviation = (float)Math.Pow((data[e] - mean),2);
                    sumdev += deviation;
                }
                variance = sumdev / numOfNums;
                sd = (float)Math.Sqrt(variance);

                Console.WriteLine("Statistcs");
                Console.WriteLine("*********");
                Console.WriteLine("Mean: {0}", mean);
                Console.WriteLine("Median: {0}", median);
                if(max > 1)
                {
                    Console.WriteLine("Mode: {0}, Occurences: {1}", mode, max);
                }
                else
                {
                    Console.WriteLine("Mode: None");
                }
                Console.WriteLine("Standard Deviation: {0}", sd);

            }


        }
    }


    // 15. arrays: stem and leaf

    public class StemAndLeaf
    {
        public static void PrintIt()
        {
            Console.WriteLine("How many numbers will you enter in your data set?");
            string numstring = Console.ReadLine();
            int numOfNums = int.Parse(numstring);
            if (numOfNums < 3)
            {
                Console.WriteLine("You need more numbers in your data set, fool.");
            }
            else
            {
                int[] data = new int[numOfNums];
                int i = 0;
                for (i = 0; i < numOfNums; i++)
                {
                    Console.WriteLine("Number {0}: ", i + 1);
                    string datastring = Console.ReadLine();
                    data[i] = int.Parse(datastring);
                }

                for (int j = 1; j < data.Length; j++)
                {
                    for (int k = 0; k < data.Length - 1; k++)
                    {
                        if (data[k] > data[k + 1])
                        {
                            int temp = data[k];
                            data[k] = data[k + 1];
                            data[k + 1] = temp;
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("The sorted array is: ");
                for (int a = 0; a < numOfNums; a++)
                {
                    Console.Write(data[a] + "\t");
                    if(a>0 && a%4 == 0)
                    {
                        Console.Write("\n");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();

                int[,] stemleaf = new int[numOfNums, 2];
                for (int b = 0; b < numOfNums; b++)
                {
                    stemleaf[b, 0] = data[b] / 10;
                    stemleaf[b, 1] = data[b] % 10;
                }

                List<int> stems = new List<int>();
                for (int d = 0; d < numOfNums; d++)
                {
                    if (stems.Contains(stemleaf[d, 0]) == false)
                    {
                        stems.Add(stemleaf[d, 0]);
                    }
                }

                int[,] occurances = new int[stems.Count, 2];
                for (int c = 0; c < stems.Count; c++)
                {
                    occurances[c, 0] = stems[c];
                    int count = 0;
                    for (int d = 0; d<numOfNums; d++)
                    {
                        if(stemleaf[c,0] == stemleaf[d,0])
                        {
                            count += 1;
                        }
                    }
                    occurances[c, 1] = count;
                }

                Console.WriteLine("Stem and Leaf Display: ");
                Console.WriteLine("Frequency \t Stem \t Leaf");

                for ( int e = 0; e < occurances.GetLength(0); e++)
                {
                    Console.Write("{0} \t \t {1} \t ", occurances[e, 1], occurances[e, 0]);
                    for (int f = 0; f < numOfNums; f++)
                    {
                        if(stemleaf[f,0] == occurances[e,0])
                        {
                            Console.Write(stemleaf[f, 1]);
                        }
                    }
                    Console.Write("\n");
                }

            }


        }
    }


    // 16. structures: record management

    public struct Student

    {
        public string Number;

        public string Name;

        public string Sex;

        public float Quiz1;

        public float Quiz2;

        public float Assigment;

        public float Midterm;

        public float Final;

        public float Total;

        public static void ShowMenu()
        {
            Console.WriteLine("**********************");
            Console.WriteLine(" \t MENU \t ");
            Console.WriteLine("**********************");

            Console.WriteLine("1. Add student records");
            Console.WriteLine("2. Delete student records");
            Console.WriteLine("3. Update student records");
            Console.WriteLine("4. View all student records");
            Console.WriteLine("5. Calculate an average of a selected student's scores");
            Console.WriteLine("6. Show student who get the max total score");
            Console.WriteLine("7. Show student who get the min total score");
            Console.WriteLine("8. Find a student by ID number");
            Console.WriteLine("9. Sort students by total score");

        }

        public static void Add(Student[] student, ref int itemcount)
        {

            int loop = 0;
            while (loop == 0)
            {
                Console.WriteLine();
                Console.Write("Enter student's ID:");
                student[itemcount].Number = Console.ReadLine().ToString();
                //making sure the record to be added doesn't already exist
                if (Search(student, student[itemcount].Number, itemcount) != -1)
                {

                    Console.WriteLine("This ID already exists.");
                }
                else
                {
                    loop = 1;
                }

            }

            Console.Write("Enter student's Name: ");
            student[itemcount].Name = Console.ReadLine().ToString();

            Console.Write("Enter student's Sex(F or M): ");
            student[itemcount].Sex = Console.ReadLine().ToString();

            Console.Write("Enter student's Quiz1 score: ");
            student[itemcount].Quiz1 = float.Parse(Console.ReadLine());

            Console.Write("Enter student's Quiz2 score: ");
            student[itemcount].Quiz2 = float.Parse(Console.ReadLine());

            Console.Write("Enter student's Assigment score: ");
            student[itemcount].Assigment = float.Parse(Console.ReadLine());

            Console.Write("Enter student's Midterm score: ");
            student[itemcount].Midterm = float.Parse(Console.ReadLine());

            Console.Write("Enter student's Final score: ");
            student[itemcount].Final = float.Parse(Console.ReadLine());

            student[itemcount].Total = student[itemcount].Quiz1 + student[itemcount].Quiz2 + student[itemcount].Assigment + student[itemcount].Midterm + student[itemcount].Final;

            ++itemcount;

        }

        public static void ViewAll(Student[] student, int itemcount)
        {

            int i = 0;

            Console.WriteLine("{0,-5}{1,-20}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}{7,-5}{8}(column index)", "0", "1", "2", "3", "4", "5", "6", "7", "8");
            Console.WriteLine("{0,-5}{1,-20}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}{7,-5}{8,-5}", "ID", "NAME", "SEX", "Q1", "Q2", "As", "Mi", "Fi", "TOTAL");

            Console.WriteLine("*********************************");

            while (i < itemcount)
            {
                if (student[i].Number != null)
                {
                    Console.Write("{0,-5}{1,-20}{2,-5}", student[i].Number, student[i].Name, student[i].Sex);
                    Console.Write("{0,-5}{1,-5}{2,-5}", student[i].Quiz1, student[i].Quiz2, student[i].Assigment);
                    Console.Write("{0,-5}{1,-5}{2,-5}", student[i].Midterm, student[i].Final, student[i].Total);
                    Console.Write("\n");
                }
                i += 1;
            }
        }

        public static int Search(Student[] student, string id, int itemcount)
        {
            int found = -1;
            for (int i = 0; i < itemcount && found == -1; i++)
            {
                if (student[i].Number == id)
                {
                    found = i;
                }
            }
            return found;

        }

        public static void Delete(Student[] student, ref int itemcount)
        {
            string id;
            int index;
            if (itemcount > 0)
            {
                Console.Write("Enter student's ID to be deleted:");
                id = Console.ReadLine();
                index = Search(student, id.ToString(), itemcount);

                if ((index != -1) && (itemcount != 0))
                {
                    if (index == (itemcount - 1))
                    {
                        Remove(student, index);
                        --itemcount;
                        Console.WriteLine("The record was deleted.");
                    }
                    else
                    {
                        for (int i = index; i < itemcount - 1; i++)
                        {
                            student[i] = student[i + 1];
                            Remove(student, itemcount);
                            --itemcount;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("The record doesn't exist. Check the ID and try again.");
                }

            }
            else
            {
                Console.WriteLine("There are no records to delete.");
            }
        }

        public static void Remove(Student[] student, int index)
        {
            student[index].Number = null;
            student[index].Name = null;
            student[index].Sex = null;
            student[index].Quiz1 = 0;
            student[index].Quiz2 = 0;
            student[index].Assigment = 0;
            student[index].Midterm = 0;
            student[index].Final = 0;
            student[index].Total = 0;
        }

        public static void Update(Student[] student, int itemcount)
        {
            string id;
            int ColumnIndex;
            Console.Write("Enter student's ID to be updated: ");
            id = Console.ReadLine();
            Console.Write("Which field you want to update(1-7)?:");
            ColumnIndex = int.Parse(Console.ReadLine());

            int index = Search(student, id.ToString(), itemcount);

            if ((index != -1) && (itemcount != 0))
            {
                if (ColumnIndex == 1)
                {
                    Console.Write("Enter student's Name: ");

                    student[index].Name = Console.ReadLine().ToString();
                }

                else if (ColumnIndex == 2)
                {
                    Console.Write("Enter student's Sex(F or M):");
                    student[index].Sex = Console.ReadLine().ToString();
                }
                else if (ColumnIndex == 3)
                {
                    Console.Write("Enter student's quizz1 score:");
                    student[index].Quiz1 = float.Parse(Console.ReadLine());
                }
                else if (ColumnIndex == 4)
                {
                    Console.Write("Enter student's quizz2 score:");
                    student[index].Quiz2 = float.Parse(Console.ReadLine());
                }
                else if (ColumnIndex == 5)
                {
                    Console.Write("Enter student's assigment score:");
                    student[index].Assigment = float.Parse(Console.ReadLine());
                }
                else if (ColumnIndex == 6)
                {
                    Console.Write("Enter student's mid term score:");
                    student[index].Midterm = float.Parse(Console.ReadLine());
                }
                else if (ColumnIndex == 7)
                {
                    Console.Write("Enter student's final score:");
                    student[index].Final = float.Parse(Console.ReadLine());
                }
                else Console.WriteLine("Invalid column index");
                student[index].Total = student[index].Quiz1 + student[index].Quiz2 + student[index].Assigment + student[index].Midterm + student[index].Final;


            }
            else Console.WriteLine("The record doesn't exist. Check the ID and try again.");

        }

        public static void Average(Student[] student, int itemcount)
        {
            string id;
            float avg = 0;
            Console.Write("Enter student's ID to find their Average Score: ");
            id = Console.ReadLine();
            int index = Search(student, id.ToString(), itemcount);
            if (index != -1 && itemcount > 0)
            {
                avg = student[index].Total / 5;
            }

            Console.WriteLine("This student's Average Score is {0}.", avg);
        }

        public static void ShowMax(Student[] student, int itemcount)
        {
            float max = student[0].Total;
            int index = 0;
            Console.WriteLine(itemcount);
            if (itemcount != 0)
            {
                for (int j = 0; j < itemcount - 1; ++j)
                    if (max < student[j + 1].Total)
                    {
                        max = student[j + 1].Total;
                        index = j + 1;
                    }
            }
            else
            {
                Console.WriteLine("No records found!");
                index = -1;
            }

            if (index != -1)
            {
                Console.WriteLine("The student with ID:{0} has the highest score: {1}.", student[index].Number, max);
            }


        }

        public static void ShowMin(Student[] student, int itemcount)
        {

            float min = student[0].Total;
            int index = 0;
            if (itemcount != 0)
            {
                for (int j = 0; j < itemcount - 1; ++j)
                    if (min > student[j + 1].Total)
                    {
                        min = student[j + 1].Total;
                        index = j + 1;
                    }
            }

            else
            {
                Console.WriteLine("No records found!");
                index = -1;
            }

            if (index != -1)
            {
                Console.WriteLine("The student with ID:{0} has the lowest score: {1}.", student[index].Number, min);
            }

        }


        public static void ShowRecord(Student[] student, int itemcount)
        {
            string id;
            Console.Write("Enter student's ID to show scores: ");
            id = Console.ReadLine();

            int index = Search(student, id.ToString(), itemcount);
            if (index != -1)
            {
                Console.Write("{0,-5}{1,-20}{2,-5}", student[index].Number, student[index].Name, student[index].Sex);
                Console.Write("{0,-5}{1,-5}{2,-5}", student[index].Quiz1, student[index].Quiz2, student[index].Assigment);
                Console.Write("{0,-5}{1,-5}{2,-5}", student[index].Midterm, student[index].Final, student[index].Total);
                Console.WriteLine();
            }
            else Console.WriteLine("That record doesn't exist.");

        }

        public static void BubbleSort(Student[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (dataset[j].Total < dataset[j - 1].Total)
                    {
                        Student temp = dataset[j];
                        dataset[j] = dataset[j - 1];
                        dataset[j - 1] = temp;
                    }

        }

        public static void MainLoop(Student[] student, int itemcount)
        {
            ShowMenu();

            int yourchoice;
            string confirm = "y";

            do
            {
                Console.Write("Enter your choice(1-9): ");
                yourchoice = int.Parse(Console.ReadLine());

                switch (yourchoice)
                {

                    case 1: Add(student, ref itemcount); break;
                    case 2: Delete(student, ref itemcount); break;
                    case 3: Update(student, itemcount); break;
                    case 4: ViewAll(student, itemcount); break;
                    case 5: Average(student, itemcount); break;
                    case 6: ShowMax(student, itemcount); break;
                    case 7: ShowMin(student, itemcount); break;
                    case 8: ShowRecord(student, itemcount); break;
                    case 9: BubbleSort(student, itemcount); break;

                    default: Console.WriteLine("Invalid Choice."); break;

                }

                Console.Write("Press y or Y to continue:");
                confirm = Console.ReadLine().ToString();

            } while (confirm == "y" || confirm == "Y");



        }

    }

    // 17. string manipulation

    public class PrefixGame
    {
        public static void Play()
        {
            string loop = "y";
            while(loop == "y")
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("\t Prefix Word Game \t");
                Console.WriteLine("******************************************");

                string string1 = "hypertext";
                string string2 = "substring";
                string string3 = "antivirus";
                string string4 = "immutable";

                string ans1 = "hyper";
                string ans2 = "sub";
                string ans3 = "anti";
                string ans4 = "im";

                string guess1, guess2, guess3, guess4;
                string result1 = "incorrect";
                string result2 = "incorrect";
                string result3 = "incorrect";
                string result4 = "incorrect";

                int score = 0;

                Console.WriteLine("What is the prefix of {0}?: ", string1);
                guess1 = Console.ReadLine();
                if (ans1 == guess1)
                {
                    score += 1;
                    result1 = "correct";
                }

                Console.WriteLine("What is the prefix of {0}?: ", string2);
                guess2 = Console.ReadLine();
                if (ans2 == guess2)
                {
                    score += 1;
                    result2 = "correct";
                }

                Console.WriteLine("What is the prefix of {0}?: ", string3);
                guess3 = Console.ReadLine();
                if (ans3 == guess3)
                {
                    score += 1;
                    result3 = "correct";
                }

                Console.WriteLine("What is the prefix of {0}?: ", string4);
                guess4 = Console.ReadLine();
                if (ans4 == guess4)
                {
                    score += 1;
                    result4 = "correct";
                }

                Console.WriteLine("******************************************");
                Console.WriteLine(" \t Check your answers \t");
                Console.WriteLine("******************************************");

                Console.WriteLine("Word \t\t Prefix  Answer");
                Console.WriteLine("hypertext \t hyper \t {0}", result1);
                Console.WriteLine("substring \t sub \t {0}", result2);
                Console.WriteLine("antivirus \t anti \t {0}", result3);
                Console.WriteLine("immutable \t im \t {0}", result4);
                Console.WriteLine();
                Console.WriteLine("Your score is: {0}", score);
                Console.WriteLine();
                Console.WriteLine("Would you like to play again? (press y to continue)");
                loop = Console.ReadLine();
            }

        }
    }

    class Execution
    {
        static void Main(string[] args)
        {
            //AgePrinter.PrintAge();
            //StarPrinter.PrintStars();
            //randomData.printData();
            //NamePrinter.PrintName();

            //SomeOperations.PrintStuff();
            //MoreOperations.PrintStuff();
            //UserInteger.PrintStuff();

            //GreatestValue.FindGreatest();
            //GradeFinder.FindGrade();

            //KeyPressCheck.CheckKey();
            //Quiz.Question();

            //DiminishingStars.PrintStars();
            //NumsAndStars.PrintIt();

            //AnotherQuiz.Question();
            //ASCIIPrinter.PrintIt();

            //AnotherQuiz2.Question();
            //ASCIIPrinter2.PrintIt();

            //NumberGame.RandomNum();
            //NumberGame2.RandomNum();

            //BubbleSorter.BubbleAsc();
            //BubbleSorter.BubbleDesc();

            //SequentialSearch.FindIt();
            //BinarySearch.FindIt();

            //Array2d.PrintIt();

            //Matrix.PrintIt();

            //PTriangle.PrintIt();

            //StatsStuff.DoTheMath();

            //StemAndLeaf.PrintIt();

            //Student.MainLoop();

            PrefixGame.Play();

            //Wait for user to acknowledge result
            Console.WriteLine();
            Console.WriteLine("Press Enter to terminate...");
            Console.ReadKey();
        }
    }
}
