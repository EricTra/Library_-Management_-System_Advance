using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Item class
    public abstract class Item
    {
        public string title;

        public string GetTitle()
        {
            return title;
        }

        public abstract void TemplateItemInfo();

        public abstract void PrintInfo();

        public abstract void UpdateInfo(string newTitle, int newYearOfPublication);
    }
}
