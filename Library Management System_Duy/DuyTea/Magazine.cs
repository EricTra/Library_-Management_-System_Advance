using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Concrete Class: Encapsulation
    public class Magazine : Item
    {
        public string Issue { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Issue: {Issue}");
        }
    }
}
