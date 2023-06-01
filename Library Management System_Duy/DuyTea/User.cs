using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    // Abstract classes
    abstract class User : IUser
    {
        protected string name;

        public string GetName()
        {
            return name;
        }
    }
}
