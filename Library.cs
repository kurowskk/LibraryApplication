using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    


    class Library
    {
        //declaring a list of books in the library
        private List<Book> _bookList;
        //declaring defauld library id. The "const" keyword makes it impossible to change the value
        /// of the field variable 
        private const int DEFAULT_LIBID_START = 100;

        public Library()
        {
        }


    }
}
