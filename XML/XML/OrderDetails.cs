using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class OrderDetails
    {
        public OrderDetails(Int32 orderId, Int32 productId, Int32 quantity, Int32 discount)
        {
            this.orderId = orderId;
            this.productId = productId;
            this.quantity = quantity;
            this.discount = discount;
        }

        private Int32 orderId;
        public Int32 OrderID { get { return orderId; } set { orderId = value; } }
        private Int32 productId;
        public Int32 ProductID { get { return productId; } set { productId = value; } }
        private Int32 quantity;
        public Int32 Quantity { get { return quantity; } set { quantity = value; } }
        private Int32 discount;
        public Int32 Discount { get { return discount; } set { discount = value; } }
    }
}
