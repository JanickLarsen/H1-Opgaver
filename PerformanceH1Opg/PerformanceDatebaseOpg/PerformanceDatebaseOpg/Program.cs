using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PerformanceDatebaseOpg
{

    
    internal class Program
    {
        private const string FILEPATH = "C:\\NumberLocation\\Numbers.txt";
        static void Main()
        {
            Controller();
        }

        #region View
        static void Draw<ItemToDraw>(ItemToDraw draw,bool NewLine)
        {
            if (NewLine)
            {
                Console.WriteLine(draw);
            }
            else
            {
                Console.Write(draw);
            }
        }
        /// <summary>
        /// The list of data is sorted fra the DB so the "WriteHighAndLow()" only need to take it and wirte
        /// </summary>
        static void WriteHighAndLow()
        {

            List<string> data = GetDataSortedList();
            Draw("Number " + data[1] + " Number of times = ", false);
            Draw(data[0], true);
            Draw("Number " + data[data.Count() - 1] + " Number of times = ", false);
            Draw(data[data.Count() - 2], false);

            Draw("", true);
        }
        /// <summary>
        /// Write the hole list from the database to the Console in a semi nice setup
        /// </summary>
        static void WriteSortedListOfNumbers() 
        {
            List<string> data = GetDataSortedList();

            Console.SetCursorPosition(0, 10);
            for (int i = 0; i < data.Count; i+= 4)
            {
                Draw("║Number " + data[i + 1] + " times = " + data[i ], false);
                Console.SetCursorPosition(25, 10 + i / 4);
                Draw("║Number " + data[i + 3] + " times = " + data[i + 2], false);
                Console.SetCursorPosition(50, 10 + i / 4);
                Draw("║", true);

            }
        }
        #endregion

        #region Controller
        static void Controller()
        {
            //Controle for the file is create and if it not it create and add 1mil random numbers from 0 -> 9999
            if (!File.Exists(FILEPATH)) {
                InputRandom(1000000);
            }
            //For The Assignment number 3,4 and 5
            WriteHighAndLow();
            //For The Assignment number 2
            //Gets the whole list and write it to the console window
            WriteSortedListOfNumbers();

            Console.ReadLine();
        }
        #endregion

        #region Model

        /// <summary>
        /// Used for the input of random numbers to a file from the filepath
        /// The data is not written to the file one at a time for no performane hit
        /// </summary>
        /// <param name="NumberOfRandoms"></param>
        static void InputRandom(int NumberOfRandoms)
        {
            Random Rng = new Random();
            StringBuilder Data = new StringBuilder();
            for (int i = 0; i < NumberOfRandoms; i++)
            {
                Data.Append(i + "; " + Rng.Next(0, 10000).ToString() + "\r\n"); 
            }
            File.AppendAllText(FILEPATH, Data.ToString());
            
        }
        /// <summary>
        /// Gets All the data from the database and put it into a List<string> 
        /// So it easy to use in the code
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        static List<string> GetData(string inputString)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(inputString, con);
            SqlDataReader sReader = cmd.ExecuteReader();
            List<string> data = new List<string>();
            while (sReader.Read()) 
            {
                data.Add(sReader[0].ToString());
                data.Add(sReader[1].ToString());
            }
            
            con.Close();
            return data;
        }

        static List<string> GetDataSortedList()
        {
            return GetData($"SELECT Count(RandomNumber) as r,RandomNumber FROM Random group by RandomNumber ORDER BY r DESC ");
        }
        static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(local);Database=Performance;Trusted_Connection=True;");
        }

        #endregion
    }
}
