using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.Entities
{
    public class Customers
    {
        Guid Id = new Guid();
        string Name { get; set; }
        string Phone { get; set; }

        private Guid orderId;

        private Guid GetOrderId()
        {
            return orderId;
        }

        private void SetOrderId(Orders order)
        {
            orderId = order.Id;
        }
    }
}
