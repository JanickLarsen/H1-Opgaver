using H1_Den_gode_systemudviklerv2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Den_gode_systemudviklerv2.Controller
{
    /// <summary>
    /// The class prepares is to make analys on data from a path
    /// </summary>
    internal class DataAnalys
    {
        /// <summary>
        /// can make a DateAnalys on a file from a Filepath
        /// </summary>
        public void MakeDateAnalys()
        {
            string filePath = "C:\\Users\\zbc23jakl\\Documents\\alarm.tx";
            View.Gui gui = new View.Gui();
            Data data = new Data();
            try
            {
                string text = data.GetTextFromFile(filePath); //Gets all the text from the file 
                gui.DisplayDataAnalysis(filePath, text.Length, data.GetFileSize(filePath), text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file does not exist");
            }
            catch (IOException)
            {
                Console.WriteLine("A error while reading the file");
            }
            catch (FormatException)
            {
                Console.WriteLine("File is not the current format try to see if the file has .txt");
            }

        }
    }
}
