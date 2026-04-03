using System;
using System.Collections.Generic;

public class Person
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

public class Student : Person
{
    public string Major { get; set; } = string.Empty;
    public int GraduationYear { get; set; }
}

public class Staff : Person
{
    public string Position { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
}

public class Book
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public int AvailableCopies { get; set; }

    public bool BorrowBook()
    {
        if (AvailableCopies <= 0)
        {
            return false;
        }

        AvailableCopies -= 1;
        return true;
    }
}

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
