using LibraryAssignmentWithCollections;

internal class Program
{
    private static void Main(string[] args)
    {
        Library library = new Library();

        IItem book1 = new Book("Dr. Máté Péter", "Normális vagy", 1214412431);
        library.AddItem(book1);
        IItem book2 = new Book("Gandalf", "Shall not pass", 1214412431);
        library.AddItem(book2);
        IItem book3= new Book("Asimov", "Robot 1", 1214412431);
        library.AddItem(book3);
        book3.Borrow("Gál János");

        IItem cd1 = new CD("Linkin Park", "Album 1", 7);
        library.AddItem(cd1);
        IItem cd2 = new CD("System of a Down", "Toxicity", 5);
        library.AddItem(cd2);

        IItem dvd1 = new DVD("Steven Spielberg", "Titanic", 180);
        library.AddItem(dvd1);

        library.PrintItems();

        Console.WriteLine();

        book3.Return();

        library.RemoveItem(book2);

        library.PrintItems();

    }
}