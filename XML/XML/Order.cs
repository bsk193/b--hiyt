using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    public class Order
    {
        public Order(Int32 orderId, DateTime orderDate)
        {
            this.orderId = orderId;
            this.orderDate = orderDate;
        }

        private Int32 orderId;
        public Int32 OrderID { get { return orderId; } set { orderId = value; } }
        private DateTime orderDate;
        public DateTime OrderDate { get { return orderDate; } set { orderDate = value; } }
    }
}
