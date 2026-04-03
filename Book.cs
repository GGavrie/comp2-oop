public class Book
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string ISBN { get; set; } = string.Empty;
    public int AvailableCopies { get; set; }

    public bool IsAvailable()
    {
        return AvailableCopies > 0;
    }

    public bool BorrowBook()
    {
        if (!IsAvailable())
        {
            return false;
        }

        AvailableCopies -= 1;
        return true;
    }

    public void ReturnBook()
    {
        AvailableCopies += 1;
    }

    public void UpdateDetails(string title, string author, string isbn, int availableCopies)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        AvailableCopies = availableCopies;
    }
}
