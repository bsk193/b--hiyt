using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class Product
    {
        public Product(Int32 productId, String productName, Int32 unitPrice, Int32 unitStock, Int32 discontinued)
        {
            this.productId = productId;
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.unitStock = unitStock;
            this.discontinued = discontinued;
        }

        private Int32 productId;
        public Int32 ProductID { get { return productId; } set { productId = value; } }
        private String productName;
        public String ProductName { get { return productName; } set { productName = value; } }
        private Int32 unitPrice;
        public Int32 UnitPrice { get { return unitPrice; } set { unitPrice = value; } }
        private Int32 unitStock;
        public Int32 UnitStock { get { return unitStock; } set { unitStock = value; } }
        private Int32 discontinued;
        public Int32 Discontinued { get { return discontinued; } set { discontinued = value; } }

    }
}
