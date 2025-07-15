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
                    1 : Add a product
                    ");
                    string ConsoleChoice = Console.ReadLine();
                    int choice = Convert.ToInt32(ConsoleChoice);
                    switch (choice)
                    {
                        case 1:
                            MainClass.AddingProduct(i);
                            break;
                    }
                }
            }
        }
         static void AddingProduct(Inventory i)
        {
            Console.WriteLine("Enter the product name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the product price");
            string ConsolePrice = Console.ReadLine();
            int price = Convert.ToInt32(ConsolePrice);

            Console.WriteLine("Enter the product quantity");
            string ConsoleQuantity = Console.ReadLine();
            int quantity = Convert.ToInt32(ConsoleQuantity);
            i.AddProduct(name, quantity, price);
        }
      
    }

}