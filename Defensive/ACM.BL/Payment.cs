using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }

    public class Payment
    {

        public int PaymentType { get; set; }
        
        public void ProcessPayment()
        {
            PaymentType paymentTypeOption;

            if(!Enum.TryParse(this.PaymentType.ToString(), out paymentTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment type", (int)this.PaymentType, typeof(PaymentType));
            }

            switch (paymentTypeOption)
            {
                case ACM.BL.PaymentType.CreditCard:
                    // Process credit card
                    break;
                case ACM.BL.PaymentType.PayPal:
                    // Process PayPal
                    break;
                default:
                    throw new ArgumentException();
            }

            // Open a connection
            // Set up stored procedure parameters with the payment data.
            // Call the saved stored procedure.

        }
    }
}
