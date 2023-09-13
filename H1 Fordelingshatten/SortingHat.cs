using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Fordelingshatten
{   
    public class SortingHat
    {
        enum Colleges { Gryffindor, Hufflepuff, Ravenclaw, Slytherin };
        public string GetCollege()
        {
            Random random = new Random();
            return ((Colleges)random.Next(0,4)).ToString();
        }

    }
}
