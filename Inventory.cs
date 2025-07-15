using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManagement
{
    class Inventory
    {
        List<Product> products = new List<Product>();
        public void view()
        {   
            foreach (Product product in products)
           {
                Console.WriteLine(@$"{product.Name} {product.Price} {product.Quantity}");
           }
        }
    }
}