using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // IteamFactory class
    public class ItemFactory
    {
        public Item getItem(string itemType)
        {
            if (itemType == "Book")
                return new Book();
            else if (itemType == "Magazine")
                return new Magazine();

            return null;
        }
    }
}
