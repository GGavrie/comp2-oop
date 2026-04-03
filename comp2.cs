using System;

public class Program
{
    public static void Main()
    {
        var library = new Library();

        var book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
        var book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
        var book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        var student1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
        var student2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
        var staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

        library.AddPatron(student1);
        library.AddPatron(student2);
        library.AddPatron(staff1);

        library.DisplayLibraryInfo();
    }
}
