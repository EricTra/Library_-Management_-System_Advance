using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace DuyTea
{
    // Main program
    public class Program
    {
        private static Library _library;
        private static LibraryComposite _libraryComposite;
        private static List<LibraryUser> _users;

        public static void Main(string[] args)
        {
            _library = new Library();
            _libraryComposite = new LibraryComposite("Library Composite");
            _users = new List<LibraryUser>();

            LoadCatalogFromDataFile();

            string choice;
            do
            {
                Console.WriteLine("********** Library Management System **********");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Magazine");
                Console.WriteLine("3. Print Catalog");
                Console.WriteLine("4. Print Library Composite");
                Console.WriteLine("5. Borrow Item");
                Console.WriteLine("6. Return Item");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        AddMagazine();
                        break;
                    case "3":
                        PrintCatalog();
                        break;
                    case "4":
                        PrintLibraryComposite();
                        break;
                    case "5":
                        BorrowItem();
                        break;
                    case "6":
                        ReturnItem();
                        break;
                    case "0":
                        Console.WriteLine("Exiting Library Management System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            } while (choice != "0");

            SaveCatalogToDataFile();
        }

        public static void AddBook()
        {
            Console.WriteLine("\nAdding Book");
            Console.WriteLine("Enter Book Details:");

            var bookFactory = new BookFactory();
            var book = (Book)bookFactory.CreateItem();

            Console.Write("Title: ");
            book.Title = Console.ReadLine();
            Console.Write("Author: ");
            book.Author = Console.ReadLine();
            Console.Write("ISBN: ");
            book.ISBN = Console.ReadLine();
            Console.Write("Genre: ");
            book.Genre = Console.ReadLine();

            _library.AddItemToCatalog(book);
            _libraryComposite.AddItem(book);

            Console.WriteLine("Book added to the catalog.");
        }

        public static void AddMagazine()
        {
            Console.WriteLine("\nAdding Magazine");
            Console.WriteLine("Enter Magazine Details:");

            var magazineFactory = new MagazineFactory();
            var magazine = (Magazine)magazineFactory.CreateItem();

            Console.Write("Title: ");
            magazine.Title = Console.ReadLine();
            Console.Write("Author: ");
            magazine.Author = Console.ReadLine();
            Console.Write("Issue: ");
            magazine.Issue = Console.ReadLine();

            _library.AddItemToCatalog(magazine);
            _libraryComposite.AddItem(magazine);

            Console.WriteLine("Magazine added to the catalog.");
        }

        public static void PrintCatalog()
        {
            _library.PrintCatalog();
        }

        public static void PrintLibraryComposite()
        {
            _libraryComposite.PrintInfo();
        }
        public static void BorrowItem()
        {
            Console.WriteLine("\nBorrowing Item");
            Console.WriteLine("Enter User Details:");

            Console.Write("User Name: ");
            var userName = Console.ReadLine();

            var user = _users.Find(u => u.Name == userName);
            if (user == null)
            {
                user = new LibraryUser(userName);
                _users.Add(user);
            }

            Console.Write("Item Title: ");
            var itemTitle = Console.ReadLine();

            var item = _library.FindItem(itemTitle);

            if (item != null)
            {
                _library.RemoveItemFromCatalog(item);  // Move this line after adding the item to the user's borrowed items list
                user.BorrowItem(item);
                Console.WriteLine("Item borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Item not found in the catalog.");
            }
        } 

        public static void ReturnItem()
        {
            Console.WriteLine("\nReturning Item");
            Console.WriteLine("Enter User Details:");

            Console.Write("User Name: ");
            var userName = Console.ReadLine();

            var user = _users.Find(u => u.Name == userName);
            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            Console.Write("Item Title: ");
            var itemTitle = Console.ReadLine();

            var item = user.BorrowedItems.Find(i => i.Title == itemTitle);
            if (item != null)
            {
                user.ReturnItem(item);
                _library.AddItemToCatalog(item);
                Console.WriteLine("Item returned successfully.");
            }
            else
            {
                Console.WriteLine("Item not found in the user's borrowed items.");
            }
        }

        public static void LoadCatalogFromDataFile()
        {
            if (File.Exists("catalog.txt"))
            {
                var lines = File.ReadAllLines("catalog.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        var itemType = parts[0];
                        var title = parts[1];
                        var author = parts[2];
                        var isbn = parts[3];
                        var genreOrIssue = parts[4];

                        Item item;
                        if (itemType == "Book")
                        {
                            item = new Book
                            {
                                Title = title,
                                Author = author,
                                ISBN = isbn,
                                Genre = genreOrIssue
                            };
                        }
                        else if (itemType == "Magazine")
                        {
                            item = new Magazine
                            {
                                Title = title,
                                Author = author,
                                Issue = genreOrIssue
                            };
                        }
                        else
                        {
                            continue;
                        }

                        _library.AddItemToCatalog(item);
                        _libraryComposite.AddItem(item);
                    }
                }
            }
        }

        public static void SaveCatalogToDataFile()
        {
            var lines = new List<string>();
            foreach (var item in _library.LibraryItems)
            {
                var itemType = item.GetType().Name;
                var title = item.Title;
                var author = item.Author;

                if (itemType == "Book")
                {
                    var book = (Book)item;
                    var isbn = book.ISBN;
                    var genre = book.Genre;
                    lines.Add($"{itemType},{title},{author},{isbn},{genre}");
                }
                else if (itemType == "Magazine")
                {
                    var magazine = (Magazine)item;
                    var issue = magazine.Issue;
                    lines.Add($"{itemType},{title},{author},{issue}");
                }
            }

            File.WriteAllLines("catalog.txt", lines);
        }
    }
}
