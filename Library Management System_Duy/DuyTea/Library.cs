using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Library class
    public class Library
    {
        private IteamFactory iteamFactory;
        private List<User> users;
        private List<Item> items;

        public Library(IteamFactory iteamFactory)
        {
            this.iteamFactory = iteamFactory;
            users = new List<User>();
            items = new List<Item>();
        }

        public List<Item> GetItems()
        {
            return items;
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void RemoveUser(User user)
        {
            users.Remove(user);
        }

        public void PrintItems()
        {
            foreach (var item in items)
            {
                item.PrintInfo();
            }
        }

        public void PrintUsers()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"User Name: {user.GetName()}");
            }
        }
    }
}
