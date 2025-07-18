namespace InventoryManagement;

    class MainClass
    {

    enum MainMenuOptions
    {
        Exit=0,
        AddProduct=1,
        ViewProduct=2,
        }

        public static void Main()
        {
            {
                Inventory i = new Inventory();
                while (true)
                {
                    Console.WriteLine(@"choose the operation :
                    1 : Add a product
                    2 : View all products
                    ");
                    string consoleChoice = Console.ReadLine();
                    if (!int.TryParse(consoleChoice, out int numericChoice))
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                        continue;
                    }
                    MainMenuOptions choice = (MainMenuOptions)numericChoice;

                switch (choice)
                {
                    case MainMenuOptions.AddProduct:
                        AddingProduct(i);
                        break;
                    case MainMenuOptions.ViewProduct:
                        i.View();
                        break;
                    }
                }
            }
        }
        
         static void AddingProduct(Inventory i)
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
            i.AddProduct(name, quantity, price);
        }
    }

