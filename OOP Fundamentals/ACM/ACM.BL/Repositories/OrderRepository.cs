using ACM.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repositories
{
    public class OrderRepository
    {
        public OrderDisplay Retrieve(int orderId)
        {
            var orderDisplay = new OrderDisplay();

            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan());
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }

            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };

                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }

        public bool Save()
        {
            return true;
        }

    }
}
