using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class LibraryItem
    {
        protected internal string title;
    }

    internal class Book : LibraryItem
    {
        LibraryItem libraryItem = new LibraryItem();
        public Book(string BookTitle) 
        {
            title = BookTitle;
        }

    }
}
