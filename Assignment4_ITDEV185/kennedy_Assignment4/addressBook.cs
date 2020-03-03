using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennedy_Assignment4
{
    class addressBook : IEnumerable
    {
        List<Person> address = new List<Person>();

        public void AddInStatePerson(string name, string addy)
        {
            address.Add(new Person { Name = name, Address = addy, Type = Person.TypeEnum.InState } );
        }

        public void AddOutOfStatePerson(string name, string addy)
        {
            address.Add(new Person { Name = name, Address = addy, Type = Person.TypeEnum.OutOfState });
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Person thePerson in address)
            {
                yield return thePerson.Name + "\n" + thePerson.Address;
            }
        }

        public IEnumerable InStatePeople
        {
            get { return FullAddress(Person.TypeEnum.InState);  }
        }

        public IEnumerable OutOfStatePeople
        {
            get { return FullAddress(Person.TypeEnum.OutOfState); }
        }

        private IEnumerable FullAddress(Person.TypeEnum type)
        {
            foreach (Person thePerson in address)
            {
                if (thePerson.Type == type)
                {
                    yield return thePerson.Name + "\n" + thePerson.Address;
                    Console.WriteLine();

                }
            }
        }

        public void RemovePerson(string item)
        {
            if (!String.IsNullOrEmpty(item))
            {
                Person toDelete = address.Find(a => a.Name.Equals(item, StringComparison.InvariantCultureIgnoreCase));
                address.Remove(toDelete);
                Console.WriteLine("Person Removed.");
            }
            else {

                Console.WriteLine("Entry was null; displaying Main Menu.");
            }
            
        }
    }

}
