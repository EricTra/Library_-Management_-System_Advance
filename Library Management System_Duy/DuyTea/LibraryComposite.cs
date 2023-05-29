using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Structural Pattern: Composite
    public class LibraryComposite : Item
    {
        private List<Item> _items;

        public LibraryComposite(string title)
        {
            Title = title;
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Library: {Title}");
            foreach (var item in _items)
            {
                item.PrintInfo();
                Console.WriteLine("--------------------");
            }
        }
    }
}
