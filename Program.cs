namespace InventoryManagement;

    class MainClass
    {
        enum MainMenuOptions
        {
            Exit=0,
        }

        public static void Main()
        {
            {
                Inventory i = new Inventory();
                while (true)
                {
                    Console.WriteLine(@"choose the operation :
                    0-Exit the application
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
                    case MainMenuOptions.Exit:
                     Console.WriteLine("Exiting the application");
                     return; 
                }
                }
            }
        }
      
    }

