using System;
using System.Text;

namespace H1_Morsekoden
{
    internal class Program
    {
        static void Main()
        {
            //gets the user input in lower case 
            string userInputString = Console.ReadLine().ToLower();
            
            StringBuilder stringBuilder = new StringBuilder();

            //Loop all the char in the string and add the mors to the stringbuilder
            for (int i = 0; i < userInputString.Length; i++)
                stringBuilder.Append(ToMors(userInputString[i]));


            //write the morse code to the user
            Console.WriteLine(stringBuilder.ToString());
            //Stop user input and the program
            Console.ReadKey(true);

            
        }
        private static string ToMors(char input)
        {
            //returns the morse code of the input char
            switch (input)
            {
                case ' ':
                    return "/";
                case 'a':
                    return ".- ";
                case 'b':
                    return "-... ";
                case 'c':
                    return "-.-. ";
                case 'd':
                    return "-.. ";
                case 'e':
                    return ". ";
                case 'f':
                    return "..-. ";
                case 'g':
                    return "--. ";
                case 'h':
                    return ".... ";
                case 'i':
                    return ".. ";
                case 'j':
                    return ".--- ";
                case 'k':
                    return "-.- ";
                case 'l':
                    return ".-.. ";
                case 'm':
                    return "-- ";
                case 'n':
                    return "-. ";
                case 'o':
                    return "--- ";
                case 'p':
                    return ".--. ";
                case 'q':
                    return "--.- ";
                case 'r':
                    return ".-. ";
                case 's':
                    return "... ";
                case 't':
                    return "- ";
                case 'u':
                    return "..- ";
                case 'v':
                    return "...- ";
                case 'w':
                    return ".-- ";
                case 'x':
                    return "-..- ";
                case 'y':
                    return "-.-- ";
                case 'z':
                    return "--.. ";
                case '1':
                    return ".---- ";
                case '2':
                    return "..--- ";
                case '3':
                    return "...-- ";
                case '4':
                    return "....- ";
                case '5':
                    return "..... ";
                case '6':
                    return "-.... ";
                case '7':
                    return "--... ";
                case '8':
                    return "---.. ";
                case '9':
                    return "----. ";
                case '0':
                    return "----- ";

                default:
                    return "";
            }
        }
    }
}
