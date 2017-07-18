using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text; 

namespace People.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PersonService.svc or PersonService.svc.cs at the Solution Explorer and start debugging.
    public class PersonService : IPersonService
    {
        public List<Person> GetPeople()
        {
            var people = new List<Person>
            {
                new Person()
                {
                    PersonId = 1,
                    FirstName = "John",
                    LastName  = "Koenig",
                    StartDate = new DateTime(1975, 10, 17),
                    Rating = 10
                },
                new Person()
                {
                    PersonId = 2,
                    FirstName = "Dylan",
                    LastName  = "Hunt",
                    StartDate = new DateTime(2000, 02, 10),
                    Rating = 8
                },
                new Person()
                {
                    PersonId = 3,
                    FirstName = "John",
                    LastName  = "Crichton",
                    StartDate = new DateTime(1999, 03, 19),
                    Rating = 6
                },
                new Person()
                {
                    PersonId = 4,
                    FirstName = "Dave",
                    LastName  = "Lister",
                    StartDate = new DateTime(1998, 02, 02),
                    Rating = 7
                },
                new Person()
                {
                    PersonId = 5,
                    FirstName = "John",
                    LastName  = "Sheridan",
                    StartDate = new DateTime(1994, 01, 26),
                    Rating = 7
                },
                new Person()
                {
                    PersonId = 6,
                    FirstName = "Dante",
                    LastName  = "Montana",
                    StartDate = new DateTime(2000, 11, 01),
                    Rating = 7
                },
                new Person()
                {
                    PersonId = 7,
                    FirstName = "Isaac",
                    LastName  = "Gampu",
                    StartDate = new DateTime(1977, 10, 09),
                    Rating = 3
                },
            };

            return people;
        }

        public Person GetPerson(int Id)
        {
            var people = GetPeople();

            return people.Where(p => p.PersonId == Id).First();
        }

        public void AddPerson(Person person) { }

        public void UpdatePerson(int Id,
                                 Person updatedPerson)
        { }
        public void DeletePerson(int Id) { }
        public void UpdatePeople(List<Person> updatedPeople) { }
    }
}
