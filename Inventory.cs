using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManagement
{
    class Inventory
    {
        List<Product> products = new List<Product>();
        public void AddProduct(string name, int quantity, int price)
        {
            Product p = new Product(name, price, quantity);
            products.Add(p);
        }
    }
}