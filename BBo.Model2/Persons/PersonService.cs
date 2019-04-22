using BBo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBo.Model.Persons
{
    public class PersonService
    {
        IPersonRepository _repository = null;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
            if (_repository == null)
                throw new ArgumentException("Repository cannot be null");
        }

        public IList<Person> GetAllPersons()
        {
            try
            {
                return _repository.GetAllPersons().ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("ERROR GetAllPersons: " + ex.ToString(), ex);
                // throw new Exception();
            }
            //throw new NotImplementedException();
        }

        public Person GetPersonById(int id)
        {
            //throw new NotImplementedException();
            try
            {
                return _repository.GetPersonById(id);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("ERROR GetPersonById: " + ex.ToString(), ex);
            }
        }
    }
}
