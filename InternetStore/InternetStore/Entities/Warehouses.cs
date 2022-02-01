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
        public Guid ProductId { get => ProductId; set => ProductId = value; }
        
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
