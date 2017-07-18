using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {

        public List<Customer> Retrieve()
        {
            InvoiceRepository invoiceRepository = new InvoiceRepository();
            List<Customer> custList = new List<Customer>
            {
                new Customer()
                {
                    CustomerId = 1,
                    FirstName = "Frodo",
                    LastName  = "Baggins",
                    EmailAddress = "fb.hob.me",
                    CustomerTypeId = 1,
                    InvoiceList = invoiceRepository.Retrieve(1)
                },
                new Customer()
                {
                    CustomerId = 2,
                    FirstName  = "Bilbo",
                    LastName   = "Baggins",
                    EmailAddress = "bb@hob.me",
                    CustomerTypeId = null,
                    InvoiceList = invoiceRepository.Retrieve(2)
                },
                new Customer()
                {
                    CustomerTypeId = 3,
                    FirstName = "Samwise",
                    LastName = "Gamgee",
                    EmailAddress = "sg@hob.me",
                    CustomerId = 1,
                    InvoiceList = invoiceRepository.Retrieve(3)
                },
                new Customer()
                {
                    CustomerId = 4,
                    FirstName = "Rosie",
                    LastName = "Cotton",
                    EmailAddress = "rc@hob.me",
                    CustomerTypeId = 2,
                    InvoiceList = invoiceRepository.Retrieve(4)
                }
            };

            return custList;
        }

        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;

            //var query = from c in customerList
            //            where c.CustomerId == customerId
            //            select c; 

            //foundCustomer = customerList.FirstOrDefault(c =>
            //                {
            //                    Debug.WriteLine(c.LastName);
            //                    return c.CustomerId == customerId;
            //                });


            //foundCustomer = customerList.Where(c =>
            //                    c.CustomerId == customerId)
            //                    .Skip(1)
            //                    .FirstOrDefault();


            foundCustomer = customerList.FirstOrDefault(c =>
                                c.CustomerId == customerId);

            return foundCustomer;
        }

        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                                .ThenBy(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName)
            //                    .ThenByDescending(c => c.FirstName);

            return SortByName(customerList).Reverse();
        }

        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue)
                               .ThenBy(c => c.CustomerTypeId);
        }


        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            return customerList.Select(c => c.LastName + ", " + c.FirstName);
        }

        public dynamic GetNamesAndEmails(List<Customer> customerList)
        {

            var query = customerList.Select(c => new
            {
                Name = c.LastName + ", " + c.FirstName,
                c.EmailAddress
            });

            foreach(var item in query)
            {
                Debug.WriteLine(item.Name + " : " + item.EmailAddress);
            }

            return query;
        }

        public dynamic GetNamesAndTypes(List<Customer> customerList,
                                        List<CustomerType>customerTypesList)
        {
            var query = customerList.Join(customerTypesList,
                                          c => c.CustomerTypeId,
                                          ct => ct.CustomerTypeId,
                                          (c, ct) => new
                                          {
                                              Name = c.LastName + ", " + c.FirstName,
                                              CustomerTypeName = ct.TypeName
                                          });

            foreach(var item in query)
            {
                Debug.WriteLine(item.Name + " : " + item.CustomerTypeName);
            }

            return query;
        }

        public IEnumerable<Customer> GetOverdueCustomers(List<Customer> customerList)
        {
            var query = customerList
                        .SelectMany(c => c.InvoiceList
                           .Where(i => (i.IsPaid ?? false) == false), 
                           (c, i) => c).Distinct();

            return query;
        }


        public dynamic GetNamesAndId(List<Customer> customerList)
        {
            var query = customerList.OrderBy(c => c.LastName)
                                    .ThenBy(c => c.FirstName)
                                    .Select(c => new
                                    {
                                        Name = c.LastName + ", " + c.FirstName,
                                        c.CustomerId
                                    });
            return query;
        }
    }
}
