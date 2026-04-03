public class Student : Person
{
    public string Major { get; set; } = string.Empty;
    public int GraduationYear { get; set; }

    public Student()
    {
    }

    public Student(string name, string email, string id, string major, int graduationYear)
        : base(name, email, id)
    {
        Major = major;
        GraduationYear = graduationYear;
    }

    public void UpdateAcademic(string major, int graduationYear)
    {
        Major = major;
        GraduationYear = graduationYear;
    }
}
