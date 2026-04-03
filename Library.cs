using System;
using System.Collections.Generic;

public class Library
{
    public List<Book> Books { get; } = new List<Book>();
    public List<Person> Patrons { get; } = new List<Person>();

    public void AddBook(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException(nameof(book));
        }

        if (string.IsNullOrWhiteSpace(book.Title) ||
            string.IsNullOrWhiteSpace(book.Author) ||
            string.IsNullOrWhiteSpace(book.ISBN))
        {
            throw new ArgumentException("Book must include Title, Author, and ISBN.", nameof(book));
        }

        if (book.AvailableCopies < 0)
        {
            throw new ArgumentException("AvailableCopies cannot be negative.", nameof(book));
        }

        Books.Add(book);
    }

    public void AddPatron(Person patron)
    {
        if (patron == null)
        {
            throw new ArgumentNullException(nameof(patron));
        }

        if (string.IsNullOrWhiteSpace(patron.Name) || string.IsNullOrWhiteSpace(patron.Email))
        {
            throw new ArgumentException("Patron must include Name and Email.", nameof(patron));
        }

        Patrons.Add(patron);
    }

    public bool IsBookAvailable(string isbn)
    {
        if (string.IsNullOrWhiteSpace(isbn))
        {
            throw new ArgumentException("ISBN cannot be empty.", nameof(isbn));
        }

        var book = FindBookByIsbn(isbn);
        return book != null && book.IsAvailable();
    }

    public bool BorrowBook(string isbn)
    {
        if (string.IsNullOrWhiteSpace(isbn))
        {
            throw new ArgumentException("ISBN cannot be empty.", nameof(isbn));
        }

        var book = FindBookByIsbn(isbn);
        if (book == null || !book.IsAvailable())
        {
            return false;
        }

        return book.BorrowBook();
    }

    public bool ReturnBook(string isbn)
    {
        if (string.IsNullOrWhiteSpace(isbn))
        {
            throw new ArgumentException("ISBN cannot be empty.", nameof(isbn));
        }

        var book = FindBookByIsbn(isbn);
        if (book == null)
        {
            return false;
        }

        book.ReturnBook();
        return true;
    }

    public void DisplayBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"{book.Title} by {book.Author} (ISBN: {book.ISBN}) - Available: {book.AvailableCopies}");
        }
    }

    public void DisplayPatrons()
    {
        foreach (var patron in Patrons)
        {
            Console.WriteLine($"{patron.Name} ({patron.Email}) - ID: {patron.ID}");
        }
    }

    public void DisplayLibraryInfo()
    {
        Console.WriteLine("Books:");
        DisplayBooks();
        Console.WriteLine();
        Console.WriteLine("Patrons:");
        DisplayPatrons();
    }

    private Book? FindBookByIsbn(string isbn)
    {
        foreach (var book in Books)
        {
            if (string.Equals(book.ISBN, isbn, StringComparison.OrdinalIgnoreCase))
            {
                return book;
            }
        }

        return null;
    }
}
