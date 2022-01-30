using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.Entities
{
    public class Orders
    {
        public Guid Id { get; set; } = new Guid();
        
        public DateTime OrderTime = DateTime.Now;
        public Guid productId;

        public Guid GetProductId()
        {
            return productId;
        }

        public void SetProductId(Products product)
        {
            productId = product.Id;
        }
        public int Current { get; set; }

        public Guid warehouseId;

        public Guid GetWarehouseId()
        {
            return warehouseId;
        }

        public void SetWarehouseId(Warehouses warehouses)
        {
            warehouseId = warehouses.Id;
        }
    }
}
