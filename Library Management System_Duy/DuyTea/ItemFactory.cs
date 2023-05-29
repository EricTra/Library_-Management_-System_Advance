using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Creational Pattern: Factory Method
    public abstract class ItemFactory
    {
        public abstract Item CreateItem();
    }

    public class BookFactory : ItemFactory
    {
        public override Item CreateItem()
        {
            return new Book();
        }
    }

    public class MagazineFactory : ItemFactory
    {
        public override Item CreateItem()
        {
            return new Magazine();
        }
    }
}
