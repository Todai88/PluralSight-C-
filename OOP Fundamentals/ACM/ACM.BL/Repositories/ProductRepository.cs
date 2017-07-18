using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repositories
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Sizes";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
