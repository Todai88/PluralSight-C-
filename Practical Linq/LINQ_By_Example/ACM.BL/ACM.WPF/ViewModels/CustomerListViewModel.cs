using ACM.BL;
using ACM.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.WPF.ViewModels
{
    public class CustomerListViewModel : ViewModelBase
    {
        private ObservableCollection<CustomerModel> _Customers;
        
        public ObservableCollection<CustomerModel> Customers
        {
            get { return _Customers; }
            set
            {
                if (_Customers != value)
                {
                    _Customers = value;
                    NotifyPropertyChanged();
                }
            }
        }

        CustomerRepository customerRepository = new CustomerRepository();
        CustomerTypeRepository customerTypeRepository = new CustomerTypeRepository();
        public CustomerListViewModel()
        {
            LoadData();
        }

        public void LoadData()
        {
            _Customers = new ObservableCollection<CustomerModel>();
            
            var customerList = customerRepository.Retrieve();
            var customerTypeList = customerTypeRepository.Retrieve();

            var query = customerList.Join(customerTypeList,
                                          c => c.CustomerTypeId,
                                          ct => ct.CustomerTypeId,
                                          (c, ct) => new CustomerModel
                                          {
                                              Name = c.LastName + ", " + c.FirstName,
                                              CustomerTypeName = ct.TypeName
                                          }); 

            foreach(var item in query.OrderBy(c => c.Name))
            {
                _Customers.Add(item);
            }
        }
    }
}
