using System;

class Program
{
    static void Main()
    {
        var library = new Library();

        library.AddBook(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
        library.AddBook(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
        library.AddBook(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));

        library.AddPatron(new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026));
        library.AddPatron(new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025));
        library.AddPatron(new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services"));

        Console.WriteLine("Books in Library:");
        DisplayBooks(library);
        Console.WriteLine("\nPatrons in Library:");
        DisplayPatrons(library);

        Console.WriteLine("\nBorrowing Books...");
        Console.WriteLine(library.BorrowBook("ISBN222")
            ? "Sandeep borrowed 'Business Insights with AI'"
            : "Sandeep could not borrow 'Business Insights with AI'");
        Console.WriteLine(library.BorrowBook("ISBN333")
            ? "Akhil borrowed 'Analytics in Action'"
            : "Akhil could not borrow 'Analytics in Action'");

        Console.WriteLine("\nBooks after borrowing:\nBooks in Library:");
        DisplayBooks(library);
    }

    static void DisplayBooks(Library library)
    {
        foreach (var b in library.Books)
            Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Available Copies: {b.AvailableCopies}");
    }

    static void DisplayPatrons(Library library)
    {
        foreach (var p in library.Patrons)
            Console.WriteLine($"Name: {p.Name}, ID: {p.ID}");
    }
}
