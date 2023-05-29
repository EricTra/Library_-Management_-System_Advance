using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Behavioral Pattern: Observer
    public interface ILibraryUserObserver
    {
        void Update(Item item);
    }
}

