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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPersonRepository" in both code and config file together.
    [ServiceContract]
    public interface IPersonService
    {

        [OperationContract]
        List<Person> GetPeople();

        [OperationContract]
        Person GetPerson(int Id);

        [OperationContract]
        void AddPerson(Person newPerson);

        [OperationContract]
        void UpdatePerson(int Id, Person updatedPerson);

        [OperationContract]
        void DeletePerson(int Id);

        [OperationContract]
        void UpdatePeople(List<Person> updatedPeople);


        // TODO: Add your service operations here
    }
}
