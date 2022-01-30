using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.Entities
{
    public class Customers
    {
       public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public string Phone { get; set; }

        private Guid orderId;

        private Guid GetOrderId()
        {
            return orderId;
        }

        private void SetOrderId(Orders order)
        {
            orderId = order.Id;
        }
        public override string ToString()
        {
            return $"{Name}\n"+$"{Phone}";
        }
    }
}
