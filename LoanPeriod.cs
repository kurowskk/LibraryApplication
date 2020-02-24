using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    class LoanPeriod
    {
         struct Loan_Period
        {
            //declaring the date the book was borrowed on
            private DateTime _borrowedOn;
            //declaring the date the book was returned on
            private DateTime _returnedOn;
            //declaring the date the book is due
            private DateTime _dueDate;

            ///Initialize the loan period object with its attributes.
            /// The constructor requires the caller to provide the date when the book was borrowed and returned in order to create a loan period. 
            public Loan_Period(DateTime borrowedOn, DateTime returnedOn, DateTime dueDate)
            {
                _borrowedOn = borrowedOn;
                _returnedOn = returnedOn;
                _dueDate = dueDate;
            }
                

            public DateTime BorrowedOn
            {
                get { return _borrowedOn; }
                set { _borrowedOn = value; }
            }

            public DateTime ReturnedOn
            {
                get { return _returnedOn; }
                set { _returnedOn = value; }
            }

            public DateTime DueTime
            {
                get { return _dueDate; }
                set { _dueDate = value; }
            }

            public void GetGetLoanDuration()
            { 
                return TimeSpan timeSpan = _borrowedOn - _returnedOn;
            }

            public TimeSpan LatePeriod
            {
                get {
                    return TimeSpan timeSpan = _returnedOn - _dueDate;
                }
            
            }


        }
    }
}
