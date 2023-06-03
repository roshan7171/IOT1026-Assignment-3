using System;

namespace Assignment
{
    public class PackTester
    {
        public static void AddEquipment(Pack pack)
        {
            bool addMoreItems = true;
            do
            {
                Console.WriteLine(pack); 

                Console.WriteLine("What do you want to add?");
                Console.WriteLine("1 - Arrow");
                Console.WriteLine("2 - Bow");
                Console.WriteLine("3 - Rope");
                Console.WriteLine("4 - Water");
                Console.WriteLine("5 - Food");
                Console.WriteLine("6 - Sword");
                Console.WriteLine("7 - Gather your pack and venture forth");

                try
                {
                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        InventoryItem? value = choice switch
                        {
                            1 => new Arrow(),
                            2 => new Bow(),
                            3 => new Rope(),
                            4 => new Water(),
                            5 => new Food(),
                            6 => new Sword(),
                            _ => null 
                        };
                        var newItem = value;

                        if (newItem != null)
                        {
                            if (!pack.Add(newItem))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Could not fit this item into the pack.");
                            }
                        }
                        else if (choice == 7)
                        {
                            Console.WriteLine("Venturing Forth!");
                            addMoreItems = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is an invalid selection.");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is an invalid selection.");
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is an invalid selection.");
                }

                Console.ResetColor();
            } while (addMoreItems);
        }
    }
}
