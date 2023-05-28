using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Concrete Class: Book (Inherits from Item)
    public class Book : Item
    {
        public string Genre { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}
