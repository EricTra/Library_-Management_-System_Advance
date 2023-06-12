using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    public class LibraryUser
    {
        public string address;
        public List<Item> borrowedItem;

        public void BorrowItem(Item item)
        {
            borrowedItem.Add(item);
        }

        public void ReturnItem(Item item)
        {
            borrowedItem.Remove(item);
        }

        public override string ToString()
        {
            return $"Address: {address}";
        }
    }
}
