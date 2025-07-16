using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManagement;

class Inventory
{
    List<Product> products = new List<Product>();

    public void DeleteProduct()
    {
        Console.Write("Enter the name of the product to delete: ");
        string name = Console.ReadLine()?.Trim() ?? "";

        Product? product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        products.Remove(product);
    }
    }