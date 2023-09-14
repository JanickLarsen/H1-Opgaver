using H1_Queue_Operations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue_Operations.View
{
    /// <summary>
    /// The class <c>Gui</c> contains the various messages that will be shown and/or sent to the console during execution.
    /// </summary>
    internal class Gui
    {
        public static void DisplayMenu()
        {
            Console.Clear();
            string[] menuItems = { "==================================================", "             H1 Queue Operations Menu", "==================================================", "1. Add donut", "2. Delete donut", "3. Show the number of donut", "4. Show the first and last donut", "5. Find an item", "6. Print all donut", "7. Exit" };

            foreach (string item in menuItems)
            {
                Console.WriteLine(item + "\n");
            }
        }
        public static void DisplayAddItemMenu()
        {
            Console.Clear();
            Console.WriteLine("Write name of the new donut: ");
        }

        public static void DisplayFindItemMenu()
        {
            Console.Clear();
            Console.Write("Input the name of item you want to find: ");
        }

        public static void OutputItem(string donut)
        {
            Console.WriteLine(donut);
        }

        public static void NumberOfItems(int numberOfItems)
        {
            Console.Clear();
            Console.WriteLine("The number of items: " + numberOfItems);
        }
        public static void ItemFindTrue()
        {
            Console.Clear();
            Console.WriteLine("The item is in the queue.");
        }

        public static void ItemFindFalse()
        {
            Console.Clear();
            Console.WriteLine("The item is not in the queue.");
        }

        public static void FirstLastItem(string first, string last)
        {
            Console.Clear();
            Console.WriteLine("The first item is: " + first);
            Console.WriteLine("The last item is: " + last);   
        } 


    }
}
