using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderController : IDisposable
    {

        private CustomerRepository customerRepository { get; set; }
        private OrderRepository orderRepository { get; set; }
        private InventoryRepository inventoryRepository{ get; set; }
        private EmailLibrary emailLibrary { get; set; }

        public void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }

        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            inventoryRepository = new InventoryRepository();
            emailLibrary = new EmailLibrary();
        }


        public OperationsResult PlaceOrder(Customer customer, 
                                Order order, 
                                Payment payment, 
                                bool allowSplitOrders, bool emailReceipt)

        {
            var op = new OperationsResult();

            if (customer == null) throw new ArgumentNullException("Customer instance is null");
            if (order == null) throw new ArgumentNullException("Order instance is null");
            if (payment == null) throw new ArgumentNullException("Payment instance is null");

            customerRepository.Add(customer);
            // Populate the order instance
           
            orderRepository.Add(order);

            var inventory = new Inventory();

            // Populate the inventory instance
           
            inventoryRepository.OrderItems(order, allowSplitOrders);

            // Process payment
            payment.ProcessPayment();


            if (emailReceipt)
            {
                string message = string.Empty;
                var result = customer.ValidateEmail();

                if (result.Success)
                { 
                    customerRepository.Update();

                    emailLibrary.SendEmail(customer.Email,
                                            "Here is your receipt");
                }
                else
                {
                    // log the message
                    if (result.MessageList.Any())
                    { 
                        result.MessageList.ForEach(m => op.AddMessage(m));
                        op.Success = false;
                    }
                }
            }

            return op;
        }
    }
}
