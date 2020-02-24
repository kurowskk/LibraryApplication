using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    enum AssetStatus
    {
        NotAvailable,
        Available,
        Loaned,
        Reserved
    }

    class LibraryAsset
    {
        //declaring an instance of a book
        private Book _book;
        //declaring id of a library branch
        private int _libID;
        //declaring availability status 
        private AssetStatus _status;
        //declaring a period for which book is borrowed
        private LoanPeriod _loanPeriod;

        ///Initialize the library asset object with its attributes.
        /// The constructor requires the caller to provide library id and book name in order to create a library asset. 
        public LibraryAsset(int libID, Book book)
        {
            _book = book;
            _libID = libID;
        }

        public int LibID
        {
            get { return _libID; }
        }

        public AssetStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public LoanPeriod LoanPeriod
        {
            get { return _loanPeriod; }
            set { _loanPeriod = value; }

        }
        public bool isAvailable
        {
            get { return isAvailable; }
        }

        public void Library-Asset(int _libID, Book book)
        {

        }









    }


}
