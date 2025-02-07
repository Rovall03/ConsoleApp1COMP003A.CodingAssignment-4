namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = new string[10];
            int[] productQuantities = new int[10];
            int count = 0;

            while (true)
            {
                int menu = 0;
                Console.WriteLine("Welcome to the Inventory Management System!");
                Console.WriteLine("Add a Product");
                Console.WriteLine("Update Product Quantity");
                Console.WriteLine("View Inventory Summary");
                Console.WriteLine("exit");
                Console.WriteLine("Enter your chioce");
                try
                {
                    menu = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    throw;
                }
                if (menu == 1)
                {
                    if (count < productNames.Length)
                    {
                        productNames[count] = "Apples";
                        productQuantities[count] = 50;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Inventory is full!");
                    }
                }

                }
        }

        }
    }
