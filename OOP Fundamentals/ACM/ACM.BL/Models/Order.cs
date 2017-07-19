using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public int OrderId { get; private set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> orderItems { get; set; }

        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (OrderDate == null)
                isValid = false;

            return isValid;
        }
    }
}
