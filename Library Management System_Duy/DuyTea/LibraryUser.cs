using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    class LibraryUser : User
    {
        private string address;
        private List<object> borrowedItems;

        public LibraryUser(string name, string address)
        {
            this.name = name;
            this.address = address;
            this.borrowedItems = new List<object>();
        }

        public void BorrowItem(object item)
        {
            borrowedItems.Add(item);
        }

        public void ReturnItem(object item)
        {
            borrowedItems.Remove(item);
        }

        public override string ToString()
        {
            string borrowedItemInfo = string.Join(", ", borrowedItems.Select(item => item.ToString()));
            return $"Name: {name}, Address: {address}, Borrowed Items: {borrowedItemInfo}";
        }
    }
}
