namespace InventoryManagement;

class UserInterface
{
    public static MainMenuOptions PrintMenu()
    {
        while (true)
        {
            Console.WriteLine("=== Main Menu ===");
            foreach (MainMenuOptions option in Enum.GetValues(typeof(MainMenuOptions)))
            {
                string name = Enum.Format(typeof(MainMenuOptions), option, "G");
                Console.WriteLine($"{(int)option}. {name}");
            }

            string consoleChoice = Console.ReadLine();
            if (!int.TryParse(consoleChoice, out int numericChoice))
            {
                Console.WriteLine("Invalid option. Please try again.");
                continue;
            }
            MainMenuOptions choice = (MainMenuOptions)numericChoice;
            return choice;
        }
    }
}