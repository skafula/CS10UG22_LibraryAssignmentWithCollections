using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignmentWithCollections
{
    internal class DVD : IItem
    {
        public string Director { get; }
        public string Title { get; }
        public int LengthInMinutes { get; }
        public int LoanPeriod { get; }

        public string Borrower { get; set; }

        public bool IsBorrowed { get; set; }

        public DVD(string director, string title, int lengthInMinutes)
        {
            Director = director;
            Title = title;
            LengthInMinutes = lengthInMinutes;
            LoanPeriod = 7;
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
                ? $"{Title} by {Director} (Minutes: {LengthInMinutes}) - borrowed by {Borrower}"
                : $"{Title} by {Director} (Minutes: {LengthInMinutes}) - available to borrow";
        }
    }
}
