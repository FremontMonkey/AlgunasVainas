using System;
using System.Collections.Generic;
using System.Text;

namespace BBo.Model.Entities
{
    public class Person
    {
        public Person() { }

        public Person(int personId, string firstName, string lastName)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
        }
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
