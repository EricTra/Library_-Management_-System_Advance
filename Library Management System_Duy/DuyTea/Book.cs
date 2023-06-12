using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Book class
    public class Book : Item
    {
        public string author;
        public int yearOfPublication;

        public override void TemplateItemInfo()
        {
            Console.WriteLine("Template Book Info");
            // Implement the template item info for Book
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Year of Publication: {yearOfPublication}");
        }

        public override void UpdateInfo(string newTitle, int newYearOfPublication)
        {
            title = newTitle;
            yearOfPublication = newYearOfPublication;
            Console.WriteLine("Book information updated.");
        }
    }
}
