using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureProofing.BL.Repositories
{
    public class PersonRepository
    {
        /// <summary>
        /// Just a bit of documentation for uploading purposes.
        /// </summary>
        /// <returns></returns>
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

        public void UpdatePerson(string lastName,
                                 Person updatedPerson) { }
        public void DeletePerson(string lastName) { }
        public void UpdatePeople(List<Person> updatedPeople) { }
    }
}
