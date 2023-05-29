using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Relationship: Unary Association
    public class Library
    {
        private LibraryCatalog _catalog;
        public List<Item> LibraryItems { get; private set; }

        public Library()
        {
            _catalog = new LibraryCatalog();
            LibraryItems = new List<Item>();
        }

        public void AddItemToCatalog(Item item)
        {
            _catalog.AddItem(item);
        }

        public void PrintCatalog()
        {
            _catalog.PrintCatalog();
        }

        public Item FindItem(string title)
        {
            return LibraryItems.FirstOrDefault(item => item.Title == title);
        }
        public void RemoveItemFromCatalog(Item item)
        {
            LibraryItems.Remove(item);
        }
    }
}
