using BBo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BBo.Model.Persons
{
    public interface IPersonRepository
    {
        Person GetPersonById(int id);
        IList<Person> GetAllPersons();
    }
}
