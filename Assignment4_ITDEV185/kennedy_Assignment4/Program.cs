using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennedy_Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            string n, a;

            addressBook addBook = new addressBook();
            Info i = new Info();

            addBook.AddInStatePerson("John", "345 Melon Grove");
            addBook.AddInStatePerson("Gary", "430 Wisconson Lane");
            addBook.AddOutOfStatePerson("Betty", "1677 Drake Avenue");
            addBook.AddOutOfStatePerson("Carol", "950 Belmont Drive");

            i.Intro();
            int input = i.Menu();
            Console.WriteLine(input);

           do 
            {
                Console.Clear();

                switch (input)
                {
                    case 1:
                        
                        Console.WriteLine("Display All Addresses:");
                        foreach (string Name in addBook)
                        {
                            Console.WriteLine(Name + " ");
                        }

                        Console.WriteLine();
                        input = i.Menu();

                        break;
                    case 2:
                        Console.WriteLine("Here is all the people in the Address Book located In-State.");
                        foreach (string Name in addBook.InStatePeople)
                        {
                            Console.Write(Name + " ");
                        }

                        Console.WriteLine();
                        input = i.Menu();

                        break;
                    case 3:
                        Console.WriteLine("Here is all the people in the Address Book located Out-Of-State.");
                        foreach (string Name in addBook.OutOfStatePeople)
                        {
                            Console.Write(Name + " ");
                        }

                        Console.WriteLine();
                        input = i.Menu();

                        break;
                    case 4:
                        //add
                        Console.Write("Enter Name: ");
                        n = Console.ReadLine();

                        Console.Write("Enter Address: ");
                        a = Console.ReadLine();

                        Console.WriteLine("In-State or Out-Of-State?");
                        Console.WriteLine("{1} In-State\t{2} Out-Of-State");
                        s = Convert.ToInt32(Console.ReadLine());
                        if (s == 1)
                        {
                            addBook.AddInStatePerson(n, a);
                        }
                        if (s == 2)
                        {
                            addBook.AddOutOfStatePerson(n, a);
                        }
                        Console.WriteLine("Successfully Added to Address Book.");

                        Console.WriteLine();
                        input = i.Menu();

                        break;
                    case 5:
                        foreach (string Name in addBook)
                        {
                            Console.WriteLine(Name);
                            Console.WriteLine();
                        }
                        Console.Write("Enter Name of Person in Address Book you wish to remove: ");
                        n = Console.ReadLine();

                        addBook.RemovePerson(n);

                        Console.WriteLine();
                        input = i.Menu();
                        break;
                    default:
                        Console.WriteLine("INPUT NOT RECOGNIZED");
                        Console.WriteLine("Please re-enter menu option.");
                        
                        Console.WriteLine();
                        input = i.Menu();
                        break;
                }
            } while ((input != 9));


            Console.WriteLine("Thank you for using the Address Book app.");
            Console.WriteLine("Goodbye.");
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}
