using System.Collections.Generic;

namespace PersonRepository.Interface
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(int Id);
        void AddPerson(Person newPerson);
        void UpdatePerson(int Id, Person updatedPerson);
        void DeletePerson(int Id);
        void UpdatePeople(IEnumerable<Person> updatePeople);
    }
}
