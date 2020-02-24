using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    class Book
    {
        ///declaring a name of each book
        private string _bookName;
        //declaring a commercial book identifier for a book
        private string _bookISBN;
        //declaring a list consisting of book authors available in the library
        private List<string> _bookAuthorList;
        //List specifing a book, libID, asset status and loan period
        private List<LibraryAsset> _libAssetList;

        ///Initialize the Book object with its attributes.
        /// The constructor requires the caller to provide book name and
        /// ISBN in order to create an digital book. 
        public Book(string Name, string bookISBN)
        {
            _bookName = Name;
            _bookISBN = bookISBN;
            
        }

        public string Name
        {
            get { return _bookName; }
        }

        public string BookISBN
        {
            get { return _bookISBN; }
        }

        public List<string> Authors
        {
            get { return _bookAuthorList; }
        }

        public IEnumerable<LibraryAsset> Assets
        {
            get { return _libAssetList; }
        }

        public bool CheckAvailibility ()
        {
            return true;
        }

        public void BorrowBook() { }


    }
}
