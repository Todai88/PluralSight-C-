using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class CustomerWin : Form
    {

        CustomerRepository customerRepository = new CustomerRepository();
        CustomerTypeRepository customerTypeRepository = new CustomerTypeRepository();

        public CustomerWin()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            var customerList = customerRepository.Retrieve();

            cbx_Customers.DisplayMember = "Name";
            cbx_Customers.ValueMember = "CustomerId";
            cbx_Customers.DataSource = customerRepository.GetNamesAndId(customerList);
        }
        private void btn_GetCustomers_Click(object sender, EventArgs e)
        {
            //grid_Customers.DataSource = customerRepository.Retrieve();

            var customerList = customerRepository.Retrieve();
            var customerTypeList = customerTypeRepository.Retrieve();
            //grid_Customers.DataSource = customerRepository.SortByName(customerList).ToList();

            //grid_Customers.DataSource = customerRepository.GetOverdueCustomers(customerList).ToList();

            grid_Customers.DataSource = customerRepository.GetNamesAndTypes(customerList, customerTypeList);
        }

        private void CustomerWin_Load(object sender, EventArgs e)
        {

        }

        private void cbx_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Customers.SelectedValue != null)
            {
                int customerId;

                if (int.TryParse(cbx_Customers.SelectedValue.ToString(), out customerId))
                {
                    var customerList = customerRepository.Retrieve();

                    grid_Customers.DataSource = new List<Customer>()
                    {
                        customerRepository.Find(customerList, customerId)
                    };
                }
            }
        }
    }
}
