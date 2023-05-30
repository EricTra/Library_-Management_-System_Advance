using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Creational Pattern: Factory Method
    public interface  ItemFactory
    {
        public  Item CreateItem();
    }

    public class BookFactory : ItemFactory
    {
        public Item CreateItem()
        {
            return new Book();
        }
    }

    public class MagazineFactory : ItemFactory
    {
        public  Item CreateItem()
        {
            return new Magazine();
        }
    }
}
