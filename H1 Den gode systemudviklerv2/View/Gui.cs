using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Den_gode_systemudviklerv2.View
{
    internal class Gui
    {
        /// <summary>
        /// Display a Analys from a file
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="characters"></param>
        /// <param name="size"></param>
        /// <param name="text"></param>
        public void DisplayDataAnalysis(string filePath, int characters, long size, string text)
        {
            Console.WriteLine($"filePath: {filePath}");
            Console.WriteLine($"Size of file: {size} byte");
            Console.WriteLine($"Number of characters: {characters}");
            Console.WriteLine("Text from file:");
            Console.WriteLine();
            Console.WriteLine(text);
        }
    }
}
