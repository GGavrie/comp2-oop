public class Person
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public void UpdateContact(string name, string email, int id)
    {
        Name = name;
        Email = email;
        ID = id;
    }
}
