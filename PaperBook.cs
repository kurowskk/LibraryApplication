using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    class PaperBook
    {
        //declaring a constant specifing the time it is allowed to keep a book for. The "const" keyword makes it impossible to change the value
        /// of the field variable 
        private const int MAX_BORROW_DAYS = 30;
        //declaring a late penalty for each day exceeding the deadine. The "const" keyword makes it impossible to change the value
        /// of the field variable 
        private const float LATE_PENALTY_PER_DAY = 0.25f;

        ///Initialize the PaperBook object with its attributes.
        /// The constructor requires the caller to provide book name and
        /// ISBN in order to create an digital book. 
        public PaperBook(string bookName, string BookISBN)
        {
            _bookName = bookName;
            _bookISBN = BookISBN;

        }
    }

}

    


        



