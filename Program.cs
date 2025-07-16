namespace InventoryManagement;

    class MainClass
    {
    enum MainMenuOptions
    {
        Exit=0,
        EditProduct=3,
    }

        public static void Main()
        {
            {
                Inventory i = new Inventory();
                while (true)
                {
                    Console.WriteLine(@"choose the operation :
                    3-Edit a product
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
                case MainMenuOptions.EditProduct:
                    i.EditProduct();
                    break;
                }
                }
            }
        }
    }

