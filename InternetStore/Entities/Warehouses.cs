using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.Entities
{
    public class Warehouses
    {
        public Guid Id = new Guid();
        string Name { get; set; }
        string Adress { get; set; }

        private Guid productId;

        private Guid GetProductId()
        {
            return productId;
        }

        private void SetProductId(Products product)
        {
            productId = product.Id;
        }
    }
}
