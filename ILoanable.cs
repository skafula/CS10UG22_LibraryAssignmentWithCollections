using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignmentWithCollections
{
    public interface ILoanable
    {
        public int LoanPeriod { get; }
        public string Borrower { get; }
        public bool IsBorrowed { get; }

        public void Borrow(string name);

        public void Return();
    }
}
