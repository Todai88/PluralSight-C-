using ACM.BL;
using Core.Common;
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
    public partial class OrderWin : Form
    {
        public OrderWin()
        {
            InitializeComponent();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            var order = new Order();
            var payment = new Payment();
            var orderController = new OrderController();

            // Populate the customer instance 
            try
            {
                orderController.PlaceOrder(customer, order, payment, 
                                            allowSplitOrders: false, 
                                            emailReceipt: false);
            }
            catch (ArgumentNullException ex)
            { 
                // Log the issue
                // Display a message to the user to say that the order wasn't successful.
            }
            
        }

        private void btn_PlaceOrder_Click(object sender, EventArgs e)
        {
            Button button = sender as Button; // Safe cast
            if(button != null)
            {
                button.Text = "Processing...";
            }
            // ((Button)sender).Text = "Processing..."; // Blind Casting
            PlaceOrder();
        }

    }
}
