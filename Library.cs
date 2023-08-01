using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignmentWithCollections
{
    public class Library
    {
        List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }

        public void PrintItems()
        {

            foreach (IItem item in items)
            {
                if (item is Book book)
                {
                    Console.WriteLine(book.Print());
                }
                else if (item is CD cd)
                {
                    Console.WriteLine(cd.Print());
                }
                else
                {
                    DVD dvd = (DVD)item;
                    Console.WriteLine(dvd.Print());
                }
            }
        }
    }
}
