using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonRepository.Interface;
using PersonRepository.Service.MyService;

namespace PersonRepository.Service
{
    public class ServiceRepository : IPersonRepository
    {
        PersonServiceClient service = new PersonServiceClient();   

        public void AddPerson(Person newPerson)
        {
            service.AddPerson(newPerson);
        }

        public void DeletePerson(int Id)
        {
            service.DeletePerson(Id);
        }

        public IEnumerable<Person> GetPeople()
        {
            return service.GetPeople();
        }

        public Person GetPerson(int Id)
        {
           return service.GetPerson(Id);
        }

        public void UpdatePeople(IEnumerable<Person> updatePeople)
        {
            service.UpdatePeople(updatePeople.ToList());
        }

        public void UpdatePerson(int Id, Person updatedPerson)
        {
            service.UpdatePerson(Id, updatedPerson);
        }
    }
}
