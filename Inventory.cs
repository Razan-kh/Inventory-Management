using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManagement;
    class Inventory
    {
        List<Product> products = new List<Product>();

        public void EditProduct()
        {
            Console.Write("Enter the name of the product to edit: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            Product? product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (product == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.Write("New name (or press Enter to keep current): ");
            string newName = Console.ReadLine()?.Trim() ?? "";
            if (!string.IsNullOrEmpty(newName))
            {
                product.Name = newName;
            }

            Console.Write("New price (or press Enter to keep current): ");
            string priceInput = Console.ReadLine()?.Trim() ?? "";
            if (int.TryParse(priceInput, out int newPrice))
            {
                product.Price = newPrice;
            }

            Console.Write("New quantity (or press Enter to keep current): ");
            string quantityInput = Console.ReadLine()?.Trim() ?? "";
            if (int.TryParse(quantityInput, out int newQuantity))
            {
                product.Quantity = newQuantity;
            }
        }
    }
