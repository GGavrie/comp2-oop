public class Staff : Person
{
    public string Position { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;

    public Staff()
    {
    }

    public Staff(string name, string email, string id, string position, string department)
        : base(name, email, id)
    {
        Position = position;
        Department = department;
    }

    public void UpdateEmployment(string position, string department)
    {
        Position = position;
        Department = department;
    }
}
