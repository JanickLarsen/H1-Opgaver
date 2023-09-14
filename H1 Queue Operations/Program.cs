using H1_Queue_Operations.Controller;
using H1_Queue_Operations.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue_Operations
{
    internal class Program
    {
        static void Main()
        {
            Logic logic = new Logic();
            logic.UserController();
        }
    }
}
