using ACM.BL.Models;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
            : this(0)
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }
        public Decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        private string _ProductName;

        public string ProductName
        {
            get
            {
                return _ProductName.InsertSpaces();
            }
            set { _ProductName = value; }
        }



        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName))
                isValid = false;
            if (CurrentPrice == null)
                isValid = false;

            return isValid;
        }
        public string Log()
        {
            var logString = this.ProductId+ ": " +
                this.ProductName + " " +
                "Email: " + this.ProductDescription + " " +
                "Status: " + this.EntityState.ToString();

            return logString;
        }

    }
}
