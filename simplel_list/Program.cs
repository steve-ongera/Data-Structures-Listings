using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of strings
        List<string> fruits = new List<string>();

        // Add items to the list
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Mango");

        // Display items
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Remove an item
        fruits.Remove("Banana");

        // Access by index
        Console.WriteLine("\nFirst fruit: " + fruits[0]);

        // Count items
        Console.WriteLine("Total fruits: " + fruits.Count);
    }
}
