using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Class representing a library user
    public class LibraryUser
    {
        private string address;
        private List<Item> borrowedItems;

        public LibraryUser(string address)
        {
            this.address = address;
            borrowedItems = new List<Item>();
        }

        public void BorrowItem(Item item)
        {
            borrowedItems.Add(item);
            Console.WriteLine("Item '" + item.GetTitle() + "' borrowed successfully.");
        }

        public void ReturnItem(Item item)
        {
            if (borrowedItems.Contains(item))
            {
                borrowedItems.Remove(item);
                Console.WriteLine("Item '" + item.GetTitle() + "' returned successfully.");
            }
            else
            {
                Console.WriteLine("Item not found in user's borrowed items.");
            }
        }

        public override string ToString()
        {
            return "Address: " + address;
        }
    }
}
