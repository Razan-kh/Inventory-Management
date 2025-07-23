using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
namespace InventoryManagement;

class Product
{
    public required string Name { set; get; }
    public required int Price { set; get; }
    public required int Quantity { set; get; }

    public override string ToString()
    {
        return $"\nProduct Found:\n" +
           $"Name: {this.Name}\n" +
           $"Price: ${this.Price}\n" +
           $"Quantity: {this.Quantity}";
    }    
    }
