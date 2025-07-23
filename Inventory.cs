using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManagement;

class Inventory
{
    List<Product> products = new List<Product>();
       
        public void SearchProduct()
        {
        products.Add(new Product { Name = "F", Price = 5, Quantity = 7 });
            Console.Write("Enter the name of the product to search: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            Product? product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (product is not null)
            {
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

    }
