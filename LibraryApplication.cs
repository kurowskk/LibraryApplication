﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    /// <summary>
    /// Creates main menu option.
    /// </summary>
    public enum MainMenuOption
    {
        SelectBook = 1,
        RegisterBook,
        ExitApplication
    }
    /// <summary>
    /// Creates book menu option.
    /// </summary>
    enum BookMenuOption
    {
        CheckStatus = 1,
        BorrowBook,
        ReturnBook,
        DisplayBookAsstes,
        ExitBookMenu
    }

    ///this enumeration creates an option of 3 formats of books in the library.
    enum BookType
    {
        Paper = 1,
        Digital,
        Audio
    }

    /// <summary>
    /// The main class of the Library application. Defines the entry point and creat the object of library.
    /// </summary>
    class LibraryApplication
    {
        //declaring an instance of a library
        private Library _library;

        /// <summary>
        /// The main method that starts the program. The args parameter that Visual Studio generates was
        /// removed as it is not used. C# allows the Main() method not to have an args parameter
        /// </summary>
        static void Main()
        {

        }

        /// <summary>
        ///Actual main method of the application. Initialized as soon as an
        /// application object is created. Creates an object of library application and makes it run.
        /// </summary>
        private void Run()
        {

        }

        /// <summary>
        ///Starts the library user interaction and diplays uesr' options
        /// </summary>
        private void Open()
        {

        }

        /// <summary>
        /// Displays the main menu of the application and prompts user for an input.
        /// </summary>
        /// <returns></returns>
        private MainMenuOption ShowMainMenu()
        {

        }

        /// <summary>
        /// Diplays menu of actions you can undergo with a book and prompts user for an input.
        /// </summary>
        /// <returns></returns>
        private BookMenuOption ShowBookMenu()
        {

        }

       // Registers a new book into the library. The user is asked for all book properties.
       // The method obtains all neccessary the information from the user in order for the  library to register a new book.
        ///The method is therefore responsible for the user interaction.
        private void OnRegisterBook()
        {

        }


        ///Selects a book by prompting the user for the book information and remembering which book was selected.
        private Book OnSelectBook()
        {

        }

        /// <summary>
        /// Allows user to perform opperation on the given book.
        /// </summary>
        /// <param name="book"></param>
        private void ManageBook(Book book)
        {

        }


        /// <summary>
        /// Prompts user to enter the book name and allows them to cancel by clicking enter.
        /// </summary>
        private string PromptForBookName()
        {
           
        }

        /// <summary>
        /// Prompts user to enter the book name and allows them to cancel by clicking enter.
        /// </summary>
        private string PromptForBookISBN()
        {

        }

        /// <summary>
        /// Prompts user to enter the book author and allows them to cancel by clicking enter.
        /// </summary>
        /// <returns></returns>
        private List<string> PromptForBookAuthors()
        {

        }

        /// <summary>
        /// Prompts user to enter the book author and allows them to cancel by clicking enter.
        /// </summary>
        /// <returns></returns>
        private BookType PromptForBookType()
        {

        }

        /// <summary>
        /// Prompts user to enter the number of copies or to cancel by clicking enter.
        /// </summary>
        /// <returns></returns>
        private int PromptForBookCopies()
        {

        }

        /// <summary>
        /// Prints the status of a given book.
        /// </summary>
        /// <param name="book"></param>
        private void OnCheckBookStatus(Book book)
        {

        }

        /// <summary>
        /// Performs the loan operation
        /// </summary>
        /// <param name="book"></param>
        private void OnBorrowBook( Book book)
        {

        }

        /// <summary>
        /// Performs the return operation
        /// </summary>
        /// <param name="book"></param>
        private void OnReturnBook(Book book)
        {

        }

        /// <summary>
        /// displays all the information related to the given book.
        /// </summary>
        /// <param name="book"></param>
        private void OnDisplayBookAssets(Book book)
        {

        }
        }





    }

    




   
