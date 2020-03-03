using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class singleLinkedList

    {
        private Node start;

        public singleLinkedList()
        {
            start = null;
        }

        public void CreateList()
        {
            int i, n, data;

            Console.WriteLine("Enter number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter element to be inserted");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            //empty list, add to first node
            if (start == null)
            {
                start = temp;
                return;
            }

            //while list is not empty
            p = start;              //get reference to start
            while (p.link != null)  //walk list to end
            {
                p = p.link;
            }
            p.link = temp;          //assign last node to our new node
        }

        public void InsertAtBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;

        }

        public void InsertAfter(int data, int x)
        {
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                {
                    break;          //found it
                }
                p = p.link;         //didnt find it, move along
            }

            if (p == null)
            {
                //made it to end of list and did not find element specified
                Console.WriteLine(x + " was not found in the list");
            }
            else
            {
                //we found x somewhere in the list
                Node temp = new Node(data);     //made new node, insert it after x
                temp.link = p.link;             //take link for new one and set it equal to reference link
                p.link = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;

            //if list is empty
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            //x is in the first node, new node is to be inserted before the first node
            if (start.info == x)
            {
                temp = new Node(data);       //made new node, insert it before x
                temp.link = start;
                start = temp;
                return;
            }

            //find a reference to the predecessor of the node containing x
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)    //the predecessor of the node containing x
                {
                    break;
                }

                //didnt find it move along to next
                p = p.link;

            }

            //didnt find x in list
            if (p.link == null)
            {
                Console.WriteLine(x + " not found in list");

            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPosition(int data, int x)
        {
            Node temp;
            int i;

            if (x == 1) //insert at beginning
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }
            //this is just like InsertAtbeginning(), can we call it?

            Node p = start;
            for (i = 1; i < x - 1 && p != null; i++)        //find reference to the x-1 node
                                                            //we're setting i = 1 and then subtracting 1 just for ease of read/to not confuse user
            {
                p = p.link;
            }

            if (p == null) //made it all the way to the end
            {
                Console.WriteLine("You can onlyinsert up to the #" + i + " position");
            }
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)                      //if list is empty
            {
                Console.WriteLine("List is empty");
                return;
            }
            //delete first node by setting start equal to start.link
            start = start.link;

        }

        public void DeleteLastNode()
        {
            Node p = start;
            //check if list empty
            if (p == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            //check for only one element
            if (start.link == null)         //if there's only 1 thing
            {
                start = null;               //just tell it to point to nothing and delete it
                return;
            }

            while (p.link.link != null)     //keep going until you get to the position of the link of your link is null
            {
                p = p.link;                 //you're at the one before the end, so set that last one's link to null, essentially deleting it
            }

            p.link = null;                  //set link of the second to last element to null, which deletes the last
        }

        public void DeleteAnyNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            //deletion of first node
            if (start.info == x)
            {
                start = start.link;
            }

            //if it didnt find it at beginning
            Node p = start;
            while (p.link != null)
            {
                if (p.link.info == x)        //found it
                {
                    break;
                }

                p = p.link;                 //otherwise move along/keep going
            }

            if (p.link == null)              //made it to the end of the list without finding x
            {
                Console.WriteLine("element specified " + x + " is not in list.");
                return;
            }
            else
            {
                p.link = p.link.link;       //found x at position p so set reference to p.link.link to skip it
            }
        }

        public void DisplayList()
        {
            Node p;
            //check if list is empty
            if (start == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            //if list isnt empty, show stuff
            Console.WriteLine("List is:  ");
            p = start;
            while (p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;

            while (p != null)
            {
                n++;
                p = p.link;
            }

            Console.WriteLine("the list has " + n + " nodes");
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while (p != null)
            {
                if (p.info == x)
                {
                    //found it, can stop looking
                    break;
                }
                //didnt find it, keep searching
                position++;
                p = p.link;

            }

            if (p == null)
            {
                Console.WriteLine(x + " 404 Item Not Found");
                return false;
            }
            else
            {
                Console.WriteLine(x + " was found at position " + position);
                return true;
            }
        }

        public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = start;

            while(p != null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }

        public void BubbleSortExchange()
        {
            Node end, p, q;

            for(end = null; end != start.link; end = p)
            {
                for(p=start; p.link !=end; p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        int temp = p.info;
                        p.info = q.info;
                        q.info = temp;
                    }
                }
            }
        }

        public void BubbleSortExLinks()
        {
            Node end, r, p, q, temp;

            for (end = null; end != start.link; end = p)
            {
                for( r = p = start; p.link != end; r = p, p = p.link)
                {
                    q = p.link;
                    if (p.info > q.info)
                    {
                        p.link = q.link;
                        q.link = p;

                        if (p != start)
                        {
                            r.link = q;
                        }
                        else
                        {
                            start = q;
                        }
                        temp = p;
                        p = q;
                        q = temp;
                    }
                }
            }
        }

        public void MergeSort()
        {
            start = MergeSortRec(start);
        }

        public Node MergeSortRec(Node listStart)
        {
            if (listStart == null || listStart.link == null)
            {
                return listStart;
            }

            Node start1 = listStart;
            Node start2 = DivideList(listStart);
            start1 = MergeSortRec(start1);
            start2 = MergeSortRec(start2);
            Node startM = Merge2(start1, start2);
            return startM;
;
        }

        private Node DivideList(Node p)
        {
            Node q = p.link.link;
            while (q != null && q.link != null)
            {
                p = p.link;
                q = q.link.link;
            }
            Node start2 = p.link;
            p.link = null;
            return start2;
        }

        private Node Merge2(Node p1, Node p2)
        {
            Node startM;
            if(p1.info <= p2.info)
            {
                startM = p1;
                p1 = p1.link;
            }
            else
            {
                startM = p2;
                p2 = p2.link;
            }

            Node pM = startM;

            while (p1 != null && p2 != null)
            {
                if(p1.info <= p2.info)
                {
                    pM.link = p1;
                    pM = pM.link;
                    p1 = p1.link;
                }
                else
                {
                    pM.link = p2;
                    pM = pM.link;
                    p2 = p2.link;
                }
            }

            if (p1 == null)
            {
                pM.link = p2;
            }
            else
            {
                pM.link = p1;
            }
            return startM;
        }

        public bool HasCycle()
        {
            if (FindCycle() == null)
            {
                return false;
            } else
            {
                return true;
            }
        }

        private Node FindCycle()
        {
            if (start == null || start.link == null)
            {
                return null;
            }

            Node slowR = start, fastR = start;

            while (fastR != null && fastR.link != null)
            {
                slowR = slowR.link;
                fastR = fastR.link.link;
                if (slowR == fastR)
                {
                    return slowR;
                }
                
            }
            return null;
        }

        public void RemoveCycle()
        {
            Node c = FindCycle();
            if (c == null)
            {
                return;
            }

            Console.WriteLine("Node at which the cycle was detected is: " + c.info);

            Node p = c; Node q = c;
            int lenCycle = 0;
            do
            {
                lenCycle++;
                q = q.link;
            } while (p != q);
            Console.WriteLine("Length of cycle is: " + lenCycle);

            int lenRemList = 0;
            p = start;
            while (p != q)
            {
                lenRemList++;
                p = p.link;
                q = q.link;
            }
            Console.WriteLine("Number of nodes included in the cycle is: " + lenRemList);

            int lengthList = lenCycle + lenRemList;
            Console.WriteLine("Length of the list is: " + lengthList);

            p = start;
            for (int i = 1; i <= lengthList - 1; i++)
            {
                p = p.link;
            }
            p.link = null;
        }

        public void InsertCycle(int x)
        {
            if (start == null)
            {
                return;
            }

            Node p = start, px = null, prev = null;

            while (p!=null)
            {
                if(p.info == x)
                {
                    px = p;
                }
                prev = p;
                p = p.link;
            }
            if (px != null)
            {
                prev.link = px;
            } else
            {
                Console.WriteLine(x + " not present in list");
            }
        }




    }
}
