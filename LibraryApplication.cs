using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public enum MainMenuOption
    {
        SelectBook = 1,
        RegisterBook,
        ExitApplication
    }
    enum Book_Menu_Option
    {
        CheckStatus = 1,
        BorrowBook,
        ReturnBook,
        DisplayBookAsstes,
        ExitBookMenu
    }

    //this enumeration creates an option of 3 formats of books in the library
    enum Type
    {
        Paper = 1,
        Digital,
        Audio
    }

    ///Initialize the Library application object with its attributes.
    /// The constructor requires the caller to provide the library name to create a library instance. 
    class LibraryApplication
    {
        //declaring an instance of a library
        private Library _library;
    }
}
