using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_ITDEV185
{
    class GenericList<T>
    {
        public void Add(T input) { }

       
        public bool MoveNext()
        {
            return false;
        }

        public GenericList<T> GetEnumerator()
        {
            return this;
        }

        public void ForEach(Action<T> action) { }

        public object Current
        {

            get { return null; }

        }


        //duck typing

        }
    }

