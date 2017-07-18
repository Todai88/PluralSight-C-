using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        /// 


        private List<Vendor> _vendors; 

        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();
            
            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }
            return vendor;
        }

        public IEnumerable<Vendor> Retrieve()
        {
            _vendors = new List<Vendor>();

            if (_vendors.Count == 0)
            { 
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 1,
                        CompanyName = "ABC Corp",
                        Email = "abc@abc.com"
                    });
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 2,
                        CompanyName = "XYZ Inc",
                        Email = "xyz@xyz.com"
                    });
            }

            return _vendors;
        }

        public IEnumerable<Vendor> RetrieveAll()
        {
            _vendors = new List<Vendor>();

            if (_vendors.Count == 0)
            {
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 1,
                        CompanyName = "ABC Corp",
                        Email = "abc@abc.com"
                    });
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 2,
                        CompanyName = "XYZ Inc",
                        Email = "xyz@xyz.com"
                    });
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 3,
                        CompanyName = "EFG Ltd",
                        Email = "efg@efg.com"
                    });
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 4,
                        CompanyName = "HIJ AG",
                        Email = "hij@hij.com"
                    });
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 5,
                        CompanyName = "Amalgamated Toys",
                        Email = "abc@abc.com"
                    });
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 6,
                        CompanyName = "Toy Blocks Inc",
                        Email = "Blocks@abc.com"
                    });
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 7,
                        CompanyName = "Home Products Inc",
                        Email = "home@abc.com"
                    });
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 8,
                        CompanyName = "Car Toys",
                        Email = "car@abc.com"
                    });
                _vendors.Add(
                    new Vendor()
                    {
                        VendorId = 9,
                        CompanyName = "Toys for Fun",
                        Email = "fun@abc.com"
                    });
            } 
            return _vendors;
        }

        public IEnumerable<Vendor> RetrieveWithIterator()
        {
            this.Retrieve();
            foreach(var vendor in _vendors)
            {
                Debug.WriteLine($"Vendor Id: {vendor.VendorId}");
                yield return vendor;
            }
        }
        //public Dictionary<int, Vendor> RetrieveWithKey()
        //{
        //    var vendors = new Dictionary<int, Vendor>()
        //    {
        //        {1, new Vendor()
        //        {
        //            VendorId = 1,
        //            CompanyName = "ABC Corp",
        //            Email = "abc@abc.com"
        //        }},
        //        {2, new Vendor()
        //        {
        //            VendorId = 2,
        //            CompanyName = "XYZ Inc",
        //            Email = "xyz@xyz.com"
        //        }}
        //    }; 
        //    return vendors;
        //}

        //public Vendor[] RetrieveArray()
        //{
        //    return new Vendor[2]
        //    {
        //        new Vendor()
        //        { VendorId = 1, CompanyName = "ABC Corp", Email = "abc@abc.com" },
        //        new Vendor()
        //        { VendorId = 2, CompanyName = "XYZ Inc", Email = "xyz@xyz.com"}
        //    };
        //}
        public T RetrieveValue<T>(string sql, T defaultValue)
        {
            T value = defaultValue;

            return value;
        }
        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }
    }
}
