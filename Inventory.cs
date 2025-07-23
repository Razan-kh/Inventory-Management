using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManagement;

class Inventory
{
    private List<Product> _products;
    public Inventory(List<Product> products)
    {
        _products = products;
    }

    public void AddProduct(string name, int quantity, int price)
    {
        Product p = new Product { Name = name, Price = price, Quantity = quantity };
        _products.Add(p);
    }
    public void View()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(@$"{product.Name} {product.Price} {product.Quantity}");
        }
    }

    public void EditProduct()
    {
        Console.Write("Enter the name of the product to edit: ");
        string name = Console.ReadLine()?.Trim() ?? string.Empty;

        Product? product = _products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (product is null)
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
    public void DeleteProduct()
    {
        Console.Write("Enter the name of the product to delete: ");
        string name = Console.ReadLine()?.Trim() ?? "";

        Product? product = _products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (product is null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        _products.Remove(product);
    }
    public void SearchProduct()
    {
        Console.Write("Enter the name of the product to search: ");
        string name = Console.ReadLine()?.Trim() ?? "";

        Product? product = _products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

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
