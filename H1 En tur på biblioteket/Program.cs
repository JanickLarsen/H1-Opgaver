using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_En_tur_på_biblioteket
{
    internal class Program
    {

        static void Main()
        {
            // list over the books a user can borrow
            List<Book> borrowList = new List<Book>
            {
                new Book("Janick's eventur","En bog om Janick der coder", "janick larsen", 5),
                new Book("harry potter","En bog om harry potter", "janick larsen", 1000),
                new Book("sej peter","Den her bog er om en sej peter", "janick larsen", 111),
                new Book("min gud","Tror gud har set den her bog måske skal du læse den", "janick larsen", 210),
                new Book("The devil","Der ingen gud her læs bogen og læs den godt", "janick larsen", 666)
            };           

            Stack<Book> stack = new Stack<Book>();
            bool stop = false;
            while (borrowList.Count > 0 && !stop)
            {
                Console.Clear();
                //Display the book left
                foreach (Book book in borrowList)
                {
                    Console.WriteLine(book.Title + " -> " + book.Description);
                }
                Console.WriteLine("\npress [End] to borrow the books");
                //Control to se what book the user whant to borrow
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        stack.Push(borrowList[0]);
                        borrowList.Remove(borrowList[0]);
                        break;
                    case ConsoleKey.D2:
                        if (borrowList.Count > 1) 
                        { 
                            stack.Push(borrowList[1]);
                            borrowList.Remove(borrowList[1]);
                        }
                        break;
                    case ConsoleKey.D3:
                        if (borrowList.Count > 2) 
                        { 
                            stack.Push(borrowList[2]);
                            borrowList.Remove(borrowList[2]);
                        }
                        break;
                    case ConsoleKey.D4:
                        if (borrowList.Count > 3) 
                        {
                            stack.Push(borrowList[3]);
                            borrowList.Remove(borrowList[3]);
                        }

                        break;
                    case ConsoleKey.D5:
                        if (borrowList.Count > 4)
                        { 
                            stack.Push(borrowList[4]);
                            borrowList.Remove(borrowList[4]);
                        }
                        break;
                    case ConsoleKey.End:
                        stop = true;
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("This is the list of your borrowed books");

            //display borrowed books
            Console.WriteLine(stack.Peek().Title + " -> " + stack.Peek().Description);
            for (int i = 0; i <= stack.Count; i++)
            {              
                stack.Pop();
                Console.WriteLine(stack.Peek().Title + " -> " + stack.Peek().Description);
            }
            Console.ReadLine();
        }
    }
}
