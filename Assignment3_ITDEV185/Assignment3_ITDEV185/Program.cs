using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_ITDEV185
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, type;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Type of Array:");
                Console.WriteLine("{1} for Integer Array");
                Console.WriteLine("{2} for Char Array");
                Console.WriteLine("{3} for String Array");
                Console.WriteLine(); 
                Console.WriteLine("{9} to Quit");

                type = Convert.ToInt32(Console.ReadLine());

                switch (type)
                {
                    case 1:
                        Console.WriteLine("Enter number of elements in array: ");
                        size = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        GenericArray<int> intArray = new GenericArray<int>(size);

                        Console.WriteLine("Enter values: ");

                        //setting values
                        for (int i = 0; i < size; i++)
                        {
                            intArray.setItem(i, Convert.ToInt32(Console.ReadLine()));
                        }
                        Console.WriteLine();

                        Console.WriteLine("Integer array is: ");
                        intArray.Display(size);
                        break;
                    case 2:

                        Console.WriteLine("Number of elements in array: ");
                        size = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        GenericArray<char> charArray = new GenericArray<char>(size);

                        Console.WriteLine("Enter values: ");
                        for (int i = 0; i < size; i++)
                        {
                            charArray.setItem(i, Convert.ToChar(Console.ReadLine()));
                        }
                
                        Console.WriteLine();

                        Console.WriteLine("Char array is: ");
                        charArray.Display(size);
                        break;

                    case 3:
                        Console.WriteLine("Number of elements in array: ");
                        size = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        GenericArray<string> stringArray = new GenericArray<string>(size);

                        Console.WriteLine("Enter values: ");
                        //setting values
                        for (int i = 0; i < size; i++)
                        {
                            stringArray.setItem(i, Console.ReadLine());
                        }
                        Console.WriteLine();

                        Console.WriteLine("String array is: ");
                        stringArray.Display(size);
                        break;

                    case 9:
                        Console.WriteLine("Goodbye.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }
           
        }
 
    }
}
