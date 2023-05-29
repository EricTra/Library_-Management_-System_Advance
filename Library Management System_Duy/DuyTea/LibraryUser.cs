using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    public class LibraryUser : ILibraryUserObserver
    {
        public string Name { get; set; }
        public List<Item> BorrowedItems { get; private set; }

        public LibraryUser(string name)
        {
            Name = name;
            BorrowedItems = new List<Item>();
        }

        public void BorrowItem(Item item)
        {
            BorrowedItems.Add(item);
            Console.WriteLine($"{Name} borrowed the item: {item.Title}");
        }

        public void ReturnItem(Item item)
        {
            BorrowedItems.Remove(item);
            Console.WriteLine($"{Name} returned the item: {item.Title}");
        }

        public void Update(Item item)
        {
            Console.WriteLine($"Notification for {Name}: The item '{item.Title}' is now available.");
        }
    }

}
