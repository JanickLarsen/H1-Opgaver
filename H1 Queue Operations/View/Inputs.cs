using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue_Operations.Model
{
    internal class Inputs
    {
        /// <summary>
        /// Reads the input on the line from the user
        /// </summary>
        /// <returns></returns>
        public string GetUserInputOnLine()
        {
            return Console.ReadLine();
        }
        /// <summary>
        /// Gets and erturn the ket presed from the user
        /// </summary>
        /// <returns></returns>
        public ConsoleKey GetConsoleKey()
        {
            return Console.ReadKey(true).Key;
        }
        /// <summary>
        /// Waits on user input 
        /// </summary>
        public void WaitOnInput()
        {
            Console.ReadKey(true);
        }
    }
}
