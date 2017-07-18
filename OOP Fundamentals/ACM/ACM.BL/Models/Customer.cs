using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        public Customer()
            : this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public static int InstanceCount { get; set; }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;

                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName))
                isValid = false;
            if (string.IsNullOrEmpty(EmailAddress))
                isValid = false;

            return isValid;
        }
    }
}
