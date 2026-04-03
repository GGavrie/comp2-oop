public class Staff : Person
{
    public string Position { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;

    public void UpdateEmployment(string position, string department)
    {
        Position = position;
        Department = department;
    }
}
