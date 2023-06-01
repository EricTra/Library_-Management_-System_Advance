using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuyTea
{
    class Magazine
    {
        private string title;
        private string editor;

        public Magazine(string title, string editor)
        {
            this.title = title;
            this.editor = editor;
        }

        public override string ToString()
        {
            return $"Title: {title}, Editor: {editor}";
        }
    }
}
