using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_password_by_flowchart
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Controller();
                while (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            } 
        }

        #region View
        static void PrintOutro()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Press Esc to exit or try again by not clicking Esc");
        }
        static void PrintIntro()
        {
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("|      Welcome to password validation     |");
            Console.WriteLine("|-----------------------------------------|");
            Console.WriteLine("| \\/ Minimum security requirements \\/");
            Console.WriteLine("| Password Need to be between 12-64 characters");
            Console.WriteLine("| Password Need to have upper and lowercase");
            Console.WriteLine("| Password Need to have numbers and letters");
            Console.WriteLine("| Password Need to have a minimum of 1 speciel character");
            Console.WriteLine("|");
            Console.WriteLine("| \\/ Requirements for ok password \\/");
            Console.WriteLine("| Has no repeating numbers or letter of 4");
            Console.WriteLine("| Has no consecutively numbers or letters or letter of 4");
            Console.WriteLine("| -----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Input password here: ");
        }
        static void PrintGrade(int grade)
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.Write("your grade is : ");
            if (grade == 0)
            {             
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Not strong enough");
            }
            else if (grade == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ok but weak");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ok");
            }
            Console.ResetColor();
            PrintOutro();
        }

        #endregion

        #region Controller
        static void Controller()
        {
            PrintIntro();
            string userPasword = GetInputByUser();

            if (!PasswordMeetRequirements(userPasword))
            {
                PrintGrade(0);
                return;
            }
            if (!PasswordIsWeak(userPasword))
            {
                PrintGrade(1);
                return;
            }   
            PrintGrade(2);
        }
        #endregion

        #region Model
        static string GetInputByUser()
        {
            //Thid is used to get the password from the user
            return Console.ReadLine();
        }
        #endregion

        #region valid
        static bool PasswordMeetRequirements(string Password)
        {
            bool[] boolCotroller = new bool[5];
            //Controle for the Password meet minimum security requirements
            if (Password.Length >= 12 && Password.Length <= 64)
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    if (Char.IsUpper(Password[i]))
                    {
                        boolCotroller[0] = true;
                    }
                    else if (Char.IsLower(Password[i]))
                    {
                        boolCotroller[1] = true;
                    }
                    if (Char.IsLetter(Password[i]))
                    {
                        boolCotroller[2] = true;
                    }
                    else if (Char.IsDigit(Password[i]))
                    {
                        boolCotroller[3] = true;
                    }
                    //Has Spiacel char
                    else
                    {
                        boolCotroller[4] = true;
                    }
                }
            }
            //Control loop for security requirements
            for (int i = 0; i < boolCotroller.Length; i++)
            {
                if (boolCotroller[i] == false)
                {          
                    return false;
                }
            }
            return true;
        }

        static bool PasswordIsWeak(string Password)
        {
            //Controle for the pasword is weak
            for (int i = 0; i < Password.Length - 4; i++)
            {
                //Controle for 4 consective char
                if (Password[i] == Password[i + 1] && Password[i + 1] == Password[i + 2] && Password[i + 2] == Password[i + 3])
                {
                    return false;
                }

                if (Convert.ToInt32(Password[i]) == (Convert.ToInt32(Password[i + 1]) - 1) && Convert.ToInt32(Password[i + 1]) == Convert.ToInt32(Password[i + 2]) - 1 && Convert.ToInt32(Password[i + 2]) == Convert.ToInt32(Password[i + 3]) - 1)
                {                           
                    return false;
                }

            }
            return true;
        }

        #endregion
    }
}
