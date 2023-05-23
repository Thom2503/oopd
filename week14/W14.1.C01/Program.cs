using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary to store contact information
		Dictionary<string, string> contacts = new Dictionary<string, string>();

        // Prompt the user for input and perform the requested operation
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Enter a command (add, view, remove, list, quit):");
            string command = Console.ReadLine();

            if (command == "add")
            {
                //Complete this section
				Console.Write("name > ");
				string name = Console.ReadLine();
				Console.Write("number > ");
				string number = Console.ReadLine();
				contacts[name] = number;
            }
            else if (command == "view")
            {
                //Complete this section
				Console.Write("name > ");
				string name = Console.ReadLine();
				try
				{
					Console.WriteLine($"Phone number: {contacts[name]}");
				}
				catch (KeyNotFoundException ex)
				{
					Console.WriteLine("Contact not found");
				}
            }
            else if (command == "remove")
            {
                //Complete this section
				Console.Write("name > ");
				string name = Console.ReadLine();
				contacts.Remove(name);
            }
            else if (command == "list")
            {
                //Complete this section
				foreach (KeyValuePair<string, string> kvp in contacts)
					Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            else if (command == "quit")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}