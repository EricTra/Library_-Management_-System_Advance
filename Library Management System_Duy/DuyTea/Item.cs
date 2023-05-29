using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Abstract Class: Abstraction, Inheritance
    public abstract class Item
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public abstract void PrintInfo();
    }
}
