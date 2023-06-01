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
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Magazine");
                Console.WriteLine("3. Add User");
                Console.WriteLine("4. Borrow Item");
                Console.WriteLine("5. Return Item");
                Console.WriteLine("6. View Items");
                Console.WriteLine("7. View Users");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Book Title: ");
                        string bookTitle = Console.ReadLine();
                        Console.Write("Enter Book Author: ");
                        string bookAuthor = Console.ReadLine();

                        library.AddItem(ItemType.Book, bookTitle, bookAuthor);

                        Console.WriteLine("Book added successfully!");
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.Write("Enter Magazine Title: ");
                        string magazineTitle = Console.ReadLine();
                        Console.Write("Enter Magazine Editor: ");
                        string magazineEditor = Console.ReadLine();

                        library.AddItem(ItemType.Magazine, magazineTitle, magazineEditor);

                        Console.WriteLine("Magazine added successfully!");
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.Write("Enter User Name: ");
                        string userName = Console.ReadLine();
                        Console.Write("Enter User Address: ");
                        string userAddress = Console.ReadLine();

                        IUser user = new LibraryUser(userName, userAddress);
                        library.AddUser(user);

                        Console.WriteLine("User added successfully!");
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.Write("Enter User Name: ");
                        string borrowerName = Console.ReadLine();
                        Console.Write("Enter Item Title: ");
                        string itemTitle = Console.ReadLine();

                        IUser borrower = library.GetUsers().FirstOrDefault(u => u.GetName() == borrowerName);
                        object item = library.GetItems().FirstOrDefault(i => i.GetTitle() == itemTitle);

                        if (borrower != null && item != null)
                        {
                            LibraryUser libraryUser = (LibraryUser)borrower;
                            libraryUser.BorrowItem(item);
                            Console.WriteLine("Item borrowed successfully!");
                        }
                        else
                        {
                            Console.WriteLine("User or Item not found!");
                        }

                        Console.WriteLine();
                        break;

                    case "5":
                        Console.Write("Enter User Name: ");
                        string returnerName = Console.ReadLine();
                        Console.Write("Enter Item Title: ");
                        string returnItemTitle = Console.ReadLine();

                        IUser returner = library.GetUsers().FirstOrDefault(u => u.GetName() == returnerName);
                        object returnItem = library.GetItems().FirstOrDefault(i => i.GetTitle() == returnItemTitle);

                        if (returner != null && returnItem != null)
                        {
                            LibraryUser libraryUser = (LibraryUser)returner;
                            libraryUser.ReturnItem(returnItem);
                            Console.WriteLine("Item returned successfully!");
                        }
                        else
                        {
                            Console.WriteLine("User or Item not found!");
                        }

                        Console.WriteLine();
                        break;

                    case "6":
                        Console.WriteLine("Library Items:");
                        library.PrintItems();
                        Console.WriteLine();
                        break;

                    case "7":
                        Console.WriteLine("Library Users:");
                        library.PrintUsers();
                        Console.WriteLine();
                        break;

                    case "8":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
