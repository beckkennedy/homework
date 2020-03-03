using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennedy_Assignment4
{
    class Info
    {
        public void Intro()
        {
            Console.WriteLine("\tWelcome to the Address Book App.");
            Console.WriteLine();
        }
        public int Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("[1] Display All");
            Console.WriteLine("[2] List In State Addresses");
            Console.WriteLine("[3] List Out of State Addresses");
            Console.WriteLine("[4] Add Entry");
            Console.WriteLine("[5] Remove Entry");
            Console.WriteLine("[9] Quit");
            int i = Convert.ToInt32(Console.ReadLine());
            return i;
        }
    }
}
