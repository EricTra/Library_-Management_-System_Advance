using DuyTea.DuyTea.DuyTea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Main class
    public class Program
    {
        private static Library library;
        private static List<LibraryUser> users;
        private static int choice;

        public static void Main(string[] args)
        {
            library = new Library();
            users = new List<LibraryUser>();
            choice = 0;

            while (choice != 7)
            {
                DisplayMenu();
                choice = GetChoice();

                switch (choice)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        RemoveItem();
                        break;
                    case 3:
                        AddUser();
                        break;
                    case 4:
                        RemoveUser();
                        break;
                    case 5:
                        PrintItems();
                        break;
                    case 6:
                        PrintUsers();
                        break;
                    case 7:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Library Menu:");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item");
            Console.WriteLine("3. Add User");
            Console.WriteLine("4. Remove User");
            Console.WriteLine("5. Print Items");
            Console.WriteLine("6. Print Users");
            Console.WriteLine("7. Exit");
        }

        private static int GetChoice()
        {
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            int choice;
            int.TryParse(input, out choice);
            return choice;
        }

        private static void AddItem()
        {
            Console.WriteLine("Enter item details:");
            Console.Write("Item Type (Book/Magazine): ");
            string itemType = Console.ReadLine();
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author/Editor: ");
            string authorEditor = Console.ReadLine();
            Console.Write("Year of Publication: ");
            int yearOfPublication;
            int.TryParse(Console.ReadLine(), out yearOfPublication);

            library.AddItem(itemType, title, authorEditor, yearOfPublication);
        }

        private static void RemoveItem()
        {
            Console.Write("Enter the title of the item to remove: ");
            string title = Console.ReadLine();

            Item itemToRemove = library.GetItems().Find(item => item.GetTitle() == title);
            if (itemToRemove != null)
            {
                library.RemoveItem(itemToRemove);
            }
            else
            {
                Console.WriteLine("Item not found in the library.");
            }
        }

        private static void AddUser()
        {
            Console.WriteLine("Enter user details:");
            Console.Write("Address: ");
            string address = Console.ReadLine();

            library.AddUser(address);
        }

        private static void RemoveUser()
        {
            Console.Write("Enter the address of the user to remove: ");
            string address = Console.ReadLine();

            LibraryUser userToRemove = library.GetUsers().Find(user => user.ToString() == "Address: " + address);
            if (userToRemove != null)
            {
                library.RemoveUser(userToRemove);
            }
            else
            {
                Console.WriteLine("User not found in the library.");
            }
        }

        private static void PrintItems()
        {
            library.PrintItems();
        }

        private static void PrintUsers()
        {
            library.PrintUsers();
        }
    }
}
