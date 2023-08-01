using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignmentWithCollections
{
    internal class CD : IItem
    {
        public string Artist { get; }
        public string Title { get; }
        public int NumberOfTracks { get; }
        public int LoanPeriod { get; }

        public string Borrower { get; set; }

        public bool IsBorrowed { get; set; }

        public CD(string artist, string title, int numberOfTracks)
        {
            Artist = artist;
            Title = title;
            NumberOfTracks = numberOfTracks;
            LoanPeriod = 14;
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
                ? $"{Title} by {Artist} (Tracks: {NumberOfTracks}) - borrowed by {Borrower}"
                : $"{Title} by {Artist} (Tracks: {NumberOfTracks}) - available to borrow";
        }
    }
}
