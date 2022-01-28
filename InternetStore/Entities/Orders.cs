using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.Entities
{
    public class Orders
    {
        public Guid Id = new Guid();
        
        public DateTime OrderTime = DateTime.Now;
        private Guid productId;

        private Guid GetProductId()
        {
            return productId;
        }

        private void SetProductId(Products product)
        {
            productId = product.Id;
        }
        public int Current { get; set; }

        private Guid warehouseId;

        private Guid GetWarehouseId()
        {
            return warehouseId;
        }

        private void SetWarehouseId(Warehouses warehouses)
        {
            warehouseId = warehouses.Id;
        }
    }
}
