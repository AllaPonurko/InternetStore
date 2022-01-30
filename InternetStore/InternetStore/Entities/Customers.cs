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
        public Guid OrderId { get => orderId; set => orderId = value; }

        private Guid orderId;

        public Guid GetOrderId()
        {
            return OrderId;
        }

        public void SetOrderId(Orders order)
        {
            OrderId = order.Id;
        }
        public override string ToString()
        {
            return $"{Name}\n"+$"{Phone}";
        }
    }
}
