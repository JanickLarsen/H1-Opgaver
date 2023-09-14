using H1_Queue_Operations.Model;
using H1_Queue_Operations.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue_Operations.Controller
{
    internal class Logic
    {
        private Inputs inputs = new Inputs();
        public Queue donutSortiment = new Queue();  // Sets up the queue which is called "donutSortiment".
        /// <summary>
        /// A controller for the worker at a donut shop 
        /// </summary>
        public void UserController() 
        {
            while (true) {
                Gui.DisplayMenu();
                switch (inputs.GetConsoleKey())
                {
                    case ConsoleKey.D1:
                        AddItem();
                        break;
                    case ConsoleKey.D2:
                        DeleteItem();
                        break;
                    case ConsoleKey.D3:
                        ShowNumberOfItems();
                        break;
                    case ConsoleKey.D4:
                        MinAndMaxItems();
                        break;
                    case ConsoleKey.D5:
                        FindItem();
                        break;
                    case ConsoleKey.D6:
                        PrintItems();
                        break;
                    case ConsoleKey.D7:
                        ExitMenu();
                        break;
                }
            }
        }
        /// <summary>
        /// Enqueue (adds) a new <c>Donut</c> to the Queue
        /// </summary>
        private void AddItem()
        {
            Gui.DisplayAddItemMenu();             
            
            Donut donut = new Donut(inputs.GetUserInputOnLine());
            donutSortiment.Enqueue(donut);
        }
        /// <summary>
        /// Remove the oldest item / first item from the Queue 
        /// </summary>
        private void DeleteItem()
        {
            donutSortiment.Dequeue();
        }
        /// <summary>
        /// Print the number of items on the "donutSortiment" Queue
        /// </summary>
        private void ShowNumberOfItems()
        {
            Gui.NumberOfItems(donutSortiment.Count);
            inputs.WaitOnInput();
        }
        /// <summary>
        ///
        /// </su
        private void MinAndMaxItems()
        {
            if (donutSortiment.Count > 0)
            {
                Donut donutFirst = (Donut)donutSortiment.Peek();
                Donut donutLast = (Donut)donutSortiment.ToArray().Last();  // By converting it into an array, we can hereby get the last element in the queue. It's not the most elegant way, but it works.
                Gui.FirstLastItem(donutFirst.Name, donutLast.Name);
                inputs.WaitOnInput();
            }
        }
        /// <summary>
        /// Looks for name of the donut to see if it in the Queue
        /// </summary>
        private void FindItem()
        {
            Gui.DisplayFindItemMenu();
            string inputname = inputs.GetUserInputOnLine();
            foreach (Donut item in donutSortiment)
            {
                if (inputname == item.Name)
                {
                    Gui.ItemFindTrue();
                    inputs.WaitOnInput();
                    return;
                }
            }
            Gui.ItemFindFalse();
            inputs.WaitOnInput();
        }
        /// <summary>
        /// Prints all the items in the Queue "donutSortiment"
        /// </summary>
        private void PrintItems()  // 
        {
            foreach (Donut item in donutSortiment)
            {
                Gui.OutputItem(item.Name);
            }
            inputs.WaitOnInput();
        }
        
        /// <summary>
        /// Close the program 
        /// </summary>
        private void ExitMenu()
        {
            Environment.Exit(0);
        }
    }
}
