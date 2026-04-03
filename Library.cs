using System;
using System.Collections.Generic;

public class Library
{
    public List<Book> Books { get; } = new List<Book>();
    public List<Person> Patrons { get; } = new List<Person>();

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
}
