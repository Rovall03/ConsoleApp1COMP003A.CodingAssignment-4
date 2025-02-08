// Author: Rosa Ovalle
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.

using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = "";
            int amount = 0;
            string[] productNames = new string[10];
            int[] productQuantities = new int[10];
            int count = 0;

            while (true)
            {
                int menu = 0;
                Console.WriteLine("Welcome to the Inventory Management System!");
                Console.WriteLine("1 Add a Product");
                Console.WriteLine("2 Update Product Quantity");
                Console.WriteLine("3 View Inventory Summary");
                Console.WriteLine("4 exit");
                Console.Write("Enter your chioce: ");
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
                        Console.Write("Name of product: ");
                        product = Console.ReadLine();

                        Console.Write("Quantity amount: ");
                        amount = int.Parse(Console.ReadLine());
                        productNames[count] = product;

                        productQuantities[count] = amount;


                        count++;
                        Console.WriteLine("Product added successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Inventory is full!");
                    }
                }

                else if (menu == 2)
                {

                    Console.Write(" name of product to update: ");

                    int index = Array.IndexOf(productNames, "Apples");
                    if (index != -1)
                    {
                        int updatedQ = int.Parse(Console.ReadLine());
                        productQuantities[index] = updatedQ;
                        Console.WriteLine("New Amount");
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }

                }
                else if (menu == 3)
                {
                    Console.WriteLine("iventory");
                    int totalQuantities = 0;


                    for (int i = 0; i < count; i++)
                    {
                        totalQuantities += productQuantities[i];
                    }
                    double sum = 0;
                    foreach (int quantiy in productQuantities)
                    {
                        sum += quantiy;


                    }
                    double average = sum / count;

                        Console.WriteLine($" {product}-{amount}");
                        Console.WriteLine($"products {count}");
                        Console.WriteLine($" Average: {average}");
                        
                    
                
                }
                    if (menu == 4)
                    {
                        break;
                    }

                
            }
        }
        }
    }
