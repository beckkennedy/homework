using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_ITDEV185
{
    class GenericArray<T>
    {
        private T[] array;

        public GenericArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int i)
        {
            return array[i];
        }
        public void setItem(int i, T value)
        {
            array[i] = value;
        }
           
        public void Display(int size)
        {
            Console.Write("[");
            for (int i = 0; i < size; i++)
            {   
                if (i == size - 1)
                {
                    Console.Write(getItem(i) + "]");
                }
                else
                {
                    Console.Write(getItem(i) + ", ");
                }
               
            }
            //Console.Write("]");
            Console.WriteLine();
        }


    }
}
