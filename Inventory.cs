using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManagement;

class Inventory
{
    List<Product> products = new List<Product>();
       
        public void SearchProduct()
        {    
            Console.Write("Enter the name of the product to search: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            Product? product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                Console.WriteLine($"\nProduct Found:");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: ${product.Price}");
                Console.WriteLine($"Quantity: {product.Quantity}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

    }
