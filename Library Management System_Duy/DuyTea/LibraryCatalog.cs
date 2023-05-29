using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Relationship: Binary Association
    public class LibraryCatalog
    {
        private List<Item> _items;

        public LibraryCatalog()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void PrintCatalog()
        {
            Console.WriteLine("Library Catalog:");
            foreach (var item in _items)
            {
                item.PrintInfo();
                Console.WriteLine("--------------------");
            }
        }
    }

}

