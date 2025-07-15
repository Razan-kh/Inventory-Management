using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
namespace InventoryManagement {
    class Product
    {
        public required string Name { set; get; }
        public  required int Price { set; get; }
        public  required int Quantity { set; get; }
        [SetsRequiredMembers]
        public Product(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
