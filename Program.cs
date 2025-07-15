namespace InventoryManagement
{
    class MainClass
    {
        public static void Main()
        {
            {
                Inventory i = new Inventory();
                while (true)
                {
                    Console.WriteLine(@"choose the operation :
                    2 : View all products
                ");
                    string ConsoleChoice = Console.ReadLine();
                    int choice = Convert.ToInt32(ConsoleChoice);
                    switch (choice)
                    {
                        case 2:
                            MainClass.ViewProduct(i);
                            break;
                    }
                }
            }
        }
              private static void ViewProduct(Inventory i)
        {
             i.view();
        }
    }

}