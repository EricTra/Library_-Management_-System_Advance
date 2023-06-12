using DuyTea.DuyTea.DuyTea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Main program
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the Library and IteamFactory
            IteamFactory itemFactory = new IteamFactory();
            Library library = new Library(itemFactory);

            // Create a list to store library users
            List<LibraryUser> users = new List<LibraryUser>();

            while (true)
            {
                Console.Clear();

                // Display the menu and get user's choice
                int choice = DisplayMenu();
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        // Add a user
                        Console.Write("Enter user name: ");
                        string userName = Console.ReadLine();
                        Console.Write("Enter user address: ");
                        string userAddress = Console.ReadLine();

                        // Create a new LibraryUser object
                        LibraryUser newUser = new LibraryUser(userName, userAddress);
                        users.Add(newUser);
                        Console.WriteLine("User added successfully.");
                        break;

                    case 2:
                        // Remove a user
                        Console.Write("Enter user name: ");
                        string userToRemove = Console.ReadLine();

                        // Find the user in the list
                        LibraryUser user = users.FirstOrDefault(u => u.GetName() == userToRemove);

                        if (user != null)
                        {
                            users.Remove(user);
                            Console.WriteLine("User removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("User not found.");
                        }
                        break;

                    case 3:
                        // Add an item
                        Console.Write("Enter item title: ");
                        string itemTitle = Console.ReadLine();

                        // Create a new item using the factory
                        Item newItem = itemFactory.GetItem(itemTitle);
                        if (newItem != null)
                        {
                            library.AddItem(newItem);
                            Console.WriteLine("Item added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid item type.");
                        }
                        break;

                    case 4:
                        // Remove an item
                        Console.Write("Enter item title: ");
                        string itemToRemove = Console.ReadLine();

                        // Find the item in the library
                        LibraryItem item = library.GetItem().FirstOrDefault(i => i.GetTitle() == itemToRemove);

                        if (item != null)
                        {
                            library.RemoveItem(item);
                            Console.WriteLine("Item removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                        break;

                    case 5:
                        // Print users
                        Console.WriteLine("Library Users:");
                        foreach (var user in users)
                        {
                            Console.WriteLine(user);
                        }
                        break;

                    case 6:
                        // Print items
                        Console.WriteLine("Library Items:");
                        foreach (var item in library.GetItem())
                        {
                            item.PrintInfo();
                        }
                        break;

                    case 7:
                        // Exit the program
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
