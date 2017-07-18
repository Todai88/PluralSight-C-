using Core.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Tests
{
    [TestClass]
    public class OrderControllerTest
    {
        public OrderController orderController { get; set; }
        public Order order { get; set; }
        [TestInitialize]
        public void TestInitialize()
        {
            orderController = new OrderController();
            order = new Order();
        }

        [TestMethod]
        public void GivenCorrectValues_WhenTestingPlaceOrder_ReturnSuccess()
        {
            // -- Arrange
             
            var customer = new Customer() { Email = "Joakim@kimput.com " }; 
            var payment = new Payment() { PaymentType = 1 };

            // -- Act
            OperationsResult op = orderController.PlaceOrder(customer, order, payment,
                                                             allowSplitOrders:true, emailReceipt:true);

            // -- Assert
            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(0, op.MessageList.Count);
        }

        [TestMethod]
        public void GivenNulledCustomer_WhenTestingPlaceOrder_ThrowExceptionAndReturnFailure()
        {
            // -- Arrange 
            var customer = new Customer() { Email = "" }; 
            var payment = new Payment() { PaymentType = 2 };

            // -- Act 

            OperationsResult op = orderController.PlaceOrder(customer, order, payment,
                                                             allowSplitOrders: true, emailReceipt: true);
            // -- Assert
            Assert.AreEqual(false, op.Success);
            Assert.AreNotEqual(0, op.MessageList);
        }

        //[TestCleanup]
        //public void TestCleanup()
        //{
        //    orderController.Dispose();
        //    order.Dispose();
        //}
    }
}
