using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Main program
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create library catalog
            var catalog = new LibraryCatalog("Main Catalog");

            // Create items using Factory Method
            var bookFactory = new BookFactory();
            var book1 = bookFactory.CreateItem();
            book1.Title = "Book 1";
            book1.Author = "Author 1";
            book1.ISBN = "ISBN-1";
            ((Book)book1).Genre = "Fiction";

            var book2 = bookFactory.CreateItem();
            book2.Title = "Book 2";
            book2.Author = "Author 2";
            book2.ISBN = "ISBN-2";
            ((Book)book2).Genre = "Mystery";

            var magazineFactory = new MagazineFactory();
            var magazine1 = magazineFactory.CreateItem();
            magazine1.Title = "Magazine 1";
            magazine1.Author = "Author 3";
            magazine1.ISBN = "ISBN-3";
            ((Magazine)magazine1).Issue = "Issue 1";

            var magazine2 = magazineFactory.CreateItem();
            magazine2.Title = "Magazine 2";
            magazine2.Author = "Author 4";
            magazine2.ISBN = "ISBN-4";
            ((Magazine)magazine2).Issue = "Issue 2";

            // Add items to catalog composite
            catalog.AddItem(book1);
            catalog.AddItem(book2);
            catalog.AddItem(magazine1);
            catalog.AddItem(magazine2);

            // Print catalog
            catalog.PrintInfo();

            // Create patrons
            var patron1 = new Patron() { Name = "Patron 1" };
            var patron2 = new Patron() { Name = "Patron 2" };

            // Perform transactions
            var transaction1 = new Transaction() { Patron = patron1, Item = book1 };
            transaction1.PrintTransaction();

            var transaction2 = new Transaction() { Patron = patron2, Item = magazine1 };
            transaction2.PrintTransaction();

            // Add observers
            var catalogObserver = new CatalogObserver();
            var patronObserver = new PatronObserver();

            ((Book)book1).PrintInfo(); // Test abstraction and encapsulation

            Console.WriteLine("\nObservers:");
            catalogObserver.Update(book1); // Test observer pattern
            patronObserver.Update(book1);

            // Print borrowed items for each patron
            patron1.BorrowedItems.Add(book1);
            patron1.BorrowedItems.Add(magazine1);
            patron1.PrintBorrowedItems();

            patron2.BorrowedItems.Add(magazine2);
            patron2.PrintBorrowedItems();

            Console.ReadLine();
        }
    }
}