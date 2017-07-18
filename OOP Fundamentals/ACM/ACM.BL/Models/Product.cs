using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }
        public Decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }
    }
}
