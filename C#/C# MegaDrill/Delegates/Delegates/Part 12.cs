using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// delegates are references to methods that have parameters and a return type, and when instantiated, can call methods that 
// have the same parameters and return types. essentially they are used to pass methods into methods. below is an example of
// a delegate used to invoke several methods on a list of groceries.


namespace Delegates
{
    // first we define the Item class, whose instances will fill a list of groceries

    public class Item
    {
        public string name;
        public decimal price;

        public Item(string Name, decimal Price)
        {
            name = Name;
            price = Price;
        }
    }

    // next we define the delegate that we will use

    public delegate void ProcessDelegate(Item item);

    // here we define the Grocery class, essentially just an array list of Item class objects

    public class Groceries
    {
        ArrayList ItemList = new ArrayList();

        // here is a method to add items to the grocery array list

        public void AddItem(string Name, decimal Price)
        {
            ItemList.Add(new Item(Name, Price));
        }

        // here is the method the delegate implements, it processes the items in the grocery list with a foreach loop

        public void ProcessItems(ProcessDelegate ProcDel)
        {
            foreach(Item item in ItemList)
            {
                ProcDel(item);
            }
        }
    }

    // the following class lays out methods to run through the list of groceries

    class TestClass
    {
        // this method simply prints the entire list of groceries and their prices

        static void PrintList(Item item)
        {
            Console.WriteLine("{0} costs {1}", item.name, item.price);
        }

        // the following method will use the delegate to seek out the highest priced item in the list

        decimal HighestPrice = 0.00m;
        string HighestItem = "";

        public void FindHighestPrice(Item item)
        {
            if (item.price > HighestPrice)
            {
                HighestPrice = item.price;
                HighestItem = item.name;
            }
        }

        // and this method will return that highest priced item

        public void ReturnHighestPrice()
        {
            Console.WriteLine("The highest priced item is {0}, with a price of {1}", HighestItem, HighestPrice);
        }

        // this method will use the delegate to seek out the sum of all the grocery prices

        decimal TotalPrice = 0.00m;

        public void FindTotalPrice(Item item)
        {
            TotalPrice += item.price;
        }

        // and this method will return that sum

        public void ReturnTotalPrice()
        {
            Console.WriteLine("The total price of all items is {0}", TotalPrice);
        }

        // here we define a last method to fill the list with groceries

        static void AddGroceries(Groceries GroceryList)
        {
            GroceryList.AddItem("Apple", 0.55m);
            GroceryList.AddItem("Bread", 2.55m);
            GroceryList.AddItem("Orange Juice", 3.20m);
            GroceryList.AddItem("Banana", 0.40m);
            GroceryList.AddItem("Milk", 3.60m);
            GroceryList.AddItem("Eggs", 2.80m);
        }


        static void Main(string[] args)
        {
            // actual execution begins here

            // first we create an instance of the grocery class

            Groceries GroceryList = new Groceries();

            // then call the method to fill it with groceries

            TestClass.AddGroceries(GroceryList);

            // below we use a delegate to cycle through the list and print each grocery item

            Console.WriteLine("Grocery List: ");
            Console.WriteLine();

            GroceryList.ProcessItems(new ProcessDelegate(PrintList));

            // next we instantiate a test class object so we can find use the other methods we defined 

            TestClass Test = new TestClass();

            // now we use a delegate to first find and return the highest priced item

            GroceryList.ProcessItems(new ProcessDelegate(Test.FindHighestPrice));
            Test.ReturnHighestPrice();

            // and lastly we use a delegate to find and return the sum of all items on the list

            GroceryList.ProcessItems(new ProcessDelegate(Test.FindTotalPrice));
            Test.ReturnTotalPrice();



            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
