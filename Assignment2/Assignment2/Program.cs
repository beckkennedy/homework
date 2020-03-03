using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            singleLinkedList list = new singleLinkedList();

            list.CreateList();
            list.DisplayList();

            while (true)
            {
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in empty list/Insert in beginning");
                Console.WriteLine("5. Insert a node at the end of the list");
                Console.WriteLine("6. Insert a node after a specified node");
                Console.WriteLine("7. Insert a node before a specified node");
                Console.WriteLine("8. Insert a node at a given position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete any node");
                Console.WriteLine("12. Reverse the list order");
                Console.WriteLine("13. Bubble sort by exchanging data");
                Console.WriteLine("14. Bubble sort by exchanging links");
                Console.WriteLine("15. Merge Sort");
                Console.WriteLine("16. Insert Cycle");
                Console.WriteLine("17. Detect Cycle");
                Console.WriteLine("18. Remove Cycle");
                
                Console.WriteLine("99. Quit");
                Console.WriteLine("You must choose. Choose wisely.");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 99)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        //Console.WriteLine("1. Display List");
                        list.DisplayList();
                        break;

                    case 2:
                        // Console.WriteLine("2. Count number of nodes");
                        list.CountNodes();
                        break;

                    case 3:
                        //  Console.WriteLine("3. Search for an element");
                        Console.WriteLine("Enter element to search for: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;

                    case 4:
                        //Console.WriteLine("4. Insert in empty list/Insert in beginning");
                        Console.WriteLine("What element would you like to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(data);
                        list.DisplayList();
                        break;

                    case 5:
                        //Console.WriteLine("5. Insert a node at the end of the list");
                        Console.WriteLine("What element would you like to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        list.DisplayList();
                        break;

                    case 6:
                        // Console.WriteLine("6. Insert a node after a specified node");
                        Console.WriteLine("What element would you like to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the element after which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        list.DisplayList();
                        break;

                    case 7:
                        //Console.WriteLine("7. Insert a node before a specified node");
                        Console.WriteLine("What element would you like to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the element after which to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        list.DisplayList();
                        break;

                    case 8:
                        //Console.WriteLine("8. Insert a node at a given position");
                        Console.WriteLine("What element would you like to insert: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the position where you would like to insert: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, x);
                        break;

                    case 9:
                        //Console.WriteLine("9. Delete first node");
                        list.DeleteFirstNode();
                        break;

                    case 10:
                        //Console.WriteLine("10. Delete last node");
                        list.DeleteLastNode();
                        break;

                    case 11:
                        //Console.WriteLine("11. Delete any node");
                        Console.WriteLine("What element would you like to delete: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.DeleteAnyNode(x);
                        break;

                    case 12:
                        //Console.WriteLine("12. Reverse");
                        list.ReverseList();
                        list.DisplayList();
                        break;

                    case 13:
                        //bubble sort by exchanging data
                        list.BubbleSortExchange();
                        list.DisplayList();
                        break;

                    case 14:
                        //bubble sort by exchanging links
                        list.BubbleSortExLinks();
                        list.DisplayList();
                        break;

                    case 15:
                        //merge sort
                        list.MergeSort();
                        break;

                    case 16:
                        //find cycle
                        Console.WriteLine("Enter element to insert a cycle");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(x);
                        break;

                    case 17:
                        //
                        if (list.HasCycle())
                        {
                            Console.WriteLine("List has a cycle");
                        }
                        else
                        {
                            Console.WriteLine("List does not have a cycle");
                        }
                        break;
                    case 18:
                        list.RemoveCycle();
                        break;
                   

                    default:
                        Console.WriteLine("You chose poorly.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
