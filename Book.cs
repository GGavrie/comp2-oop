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
