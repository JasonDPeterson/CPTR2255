using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAIRS
{
    internal class LAIRS
    {
        static void Main(string[] args)
        {
            PrintHeader();
            int mainMenuOption = 0;

            while (mainMenuOption != 2)
            {
                mainMenuOption = GetMainMenuOption();

                switch (mainMenuOption)
                {
                    case 1:
                        Console.WriteLine("Do stuff");
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PrintHeader()
        {
            Console.WriteLine("LAIRS Character Creation System.");
            Console.WriteLine("    ****** MAIN MENU ******     ");
            Console.WriteLine("1.) DND Character Creation.");
            Console.WriteLine("2.) Exit.");
            Console.WriteLine("");
        }

        private static int GetMainMenuOption()
        {
            Console.Write("Option Selected: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
