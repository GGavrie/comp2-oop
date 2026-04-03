public class Student : Person
{
    public string Major { get; set; } = string.Empty;
    public int GraduationYear { get; set; }

    public void UpdateAcademic(string major, int graduationYear)
    {
        Major = major;
        GraduationYear = graduationYear;
    }
}
