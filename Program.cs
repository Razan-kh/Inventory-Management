namespace InventoryManagement;

    class MainClass
    {

        public static void Main()
        {
            {
                List<Product> products = new List<Product>();
                Inventory inventory = new Inventory(products);
                while (true)
                {
                MainMenuOptions choice = UserInterfaceClass.PrintMenu(); 
                switch (choice)
                {
                    case MainMenuOptions.AddProduct:
                        AddingProduct(inventory);
                        break;
                    case MainMenuOptions.ViewProduct:
                        inventory.View();
                        break;
                    case MainMenuOptions.EditProduct:
                    inventory.EditProduct();
                    break;
                    }
                }
            }
        }
        
         static void AddingProduct(Inventory inventory)
        {
            Console.WriteLine("Enter the product name");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid option. Please try again.");
                name = Console.ReadLine();
            }
            Console.WriteLine("Enter the product price");
            string consolePrice = Console.ReadLine();
            int price;
            while (!int.TryParse(consolePrice, out price) || price < 0)
            {
                Console.WriteLine("Invalid option. Please try again.");
                consolePrice = Console.ReadLine();
            }
           
            Console.WriteLine("Enter the product quantity");
            string consoleQuantity = Console.ReadLine();
            int quantity;
            while (!int.TryParse(consoleQuantity, out quantity) || quantity < 0)
            {
                Console.WriteLine("Invalid option. Please try again.");
                consoleQuantity = Console.ReadLine();
            }
            inventory.AddProduct(name, quantity, price);
        }
    }

