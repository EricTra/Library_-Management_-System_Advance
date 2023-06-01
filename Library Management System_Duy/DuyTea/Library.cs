using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Behavioral Pattern
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DuyTea
    {
        using System;
        using System.Collections.Generic;

        namespace DuyTea
        {
            // Behavioral Pattern
            class Library
            {
                private List<LibraryItem> items;
                private List<IUser> users;

                public Library()
                {
                    this.items = new List<LibraryItem>();
                    this.users = new List<IUser>();
                }

                public List<IUser> GetUsers()
                {
                    return users;
                }

                public List<LibraryItem> GetItems()
                {
                    return items;
                }

                public void AddItem(ItemType itemType, string title, string details)
                {
                    LibraryItem item = (LibraryItem)ItemFactory.CreateItem(itemType, title, details);
                    items.Add(item);
                }

                public void RemoveItem(LibraryItem item)
                {
                    items.Remove(item);
                }

                public void AddUser(IUser user)
                {
                    users.Add(user);
                }

                public void RemoveUser(IUser user)
                {
                    users.Remove(user);
                }

                public void PrintItems()
                {
                    foreach (var item in items)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                public void PrintUsers()
                {
                    foreach (var user in users)
                    {
                        Console.WriteLine(user.ToString());
                    }
                }
            }
        }
    }
}
