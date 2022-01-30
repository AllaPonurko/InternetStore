using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.Entities
{
    public class Warehouses
    {
        public Guid Id { get; set; } = new Guid();
        string Name { get; set; }
        string Adress { get; set; }
        public Guid ProductId { get => productId; set => productId = value; }

        private Guid productId;

        public Guid GetProductId()
        {
            return ProductId;
        }

        public void SetProductId(Products product)
        {
            ProductId = product.Id;
        }
    }
}
