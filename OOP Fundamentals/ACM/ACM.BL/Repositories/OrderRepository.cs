using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repositories
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                //order.OrderDate = new DateTimeOffset(2014);
            }

            return order;
        }

        public bool Save()
        {
            return true;
        }

    }
}
