using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignmentWithCollections
{
    public class Book : IItem
    {
        public string Author { get; }
        public string Title { get; }
        public int ISBN { get; }
        public int LoanPeriod { get; }

        public string Borrower { get; set; }

        public bool IsBorrowed { get; set; }

        public Book(string author, string title, int isbn)
        {
            Author = author;
            Title = title;
            ISBN = isbn;
            LoanPeriod = 21;
            IsBorrowed = false;
            Borrower = "";
        }

        public void Borrow(string name)
        {
            this.Borrower = name;
            this.IsBorrowed = true;
        }

        public void Return()
        {
            this.Borrower = "";
            this.IsBorrowed = false;
        }
        public string Print()
        {
            return this.IsBorrowed == true
                ? $"{Title} by {Author} (ISBN: {ISBN}) - borrowed by {Borrower}"
                : $"{Title} by {Author} (ISBN: {ISBN}) - available to borrow";
        }
    }
}
