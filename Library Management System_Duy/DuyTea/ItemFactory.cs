using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Factory Pattern
    public class ItemFactory
    {
        private ItemFactory()
        {
        }

        public static object CreateItem(ItemType itemType, string title, string details)
        {
            switch (itemType)
            {
                case ItemType.Book:
                    return new Book(title, details);

                case ItemType.Magazine:
                    return new Magazine(title, details);

                default:
                    throw new ArgumentException("This item type is unsupported");
            }
        }
    }

    public enum ItemType
    {
        Book,
        Magazine
    }
}
