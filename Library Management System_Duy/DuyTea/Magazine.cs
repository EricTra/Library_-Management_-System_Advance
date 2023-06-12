using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Magazine class
    public class Magazine : Item
    {
        public string editor;
        public int yearOfPublication;

        public override void TemplateItemInfo()
        {
            Console.WriteLine("Template Magazine Info");
            // Implement the template item info for Magazine
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Magazine Title: {title}");
            Console.WriteLine($"Editor: {editor}");
            Console.WriteLine($"Year of Publication: {yearOfPublication}");
        }

        public override void UpdateInfo(string newTitle, int newYearOfPublication)
        {
            title = newTitle;
            yearOfPublication = newYearOfPublication;
            Console.WriteLine("Magazine information updated.");
        }
    }
}
