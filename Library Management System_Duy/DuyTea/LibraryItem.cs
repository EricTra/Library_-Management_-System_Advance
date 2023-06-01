using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Abstract classes
    abstract class LibraryItem 
    {
        protected string title;

        public string GetTitle()
        {
            return title;
        }
    }
}
