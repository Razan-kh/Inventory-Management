namespace InventoryManagement;

    class MainClass
    {
    enum MainMenuOptions
    {
        Exit=0,
        ViewProduct=2,
        }

        public static void Main()
        {
            {
                Inventory i = new Inventory();
                while (true)
                {
                    Console.WriteLine(@"choose the operation :
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
                    case MainMenuOptions.ViewProduct:
                        i.View();
                        break;
                }
                }
            }
        }
    }

