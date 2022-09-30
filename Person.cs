using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Person : IComparable<Person>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public Address Address { get; init; }
        
        //constructor
        public Person(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public override string ToString()
        {
            return FirstName + "|" + LastName + "|";
        }

        public int CompareTo(Person lName)
        {
            return this.LastName.CompareTo(lName.LastName);
        }
    }
}
