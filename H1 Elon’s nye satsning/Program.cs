using H1_Elon_s_nye_satsning.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace H1_Elon_s_nye_satsning
{
    internal class Program
    {
        static void Main()
        {
            Controller.Controller controller = new Controller.Controller();
            controller.start();
        }

    }
}
