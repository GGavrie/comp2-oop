public class Person
{
    public string ID { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public Person()
    {
    }

    public Person(string name, string email, string id)
    {
        Name = name;
        Email = email;
        ID = id;
    }

    public void UpdateContact(string name, string email, string id)
    {
        Name = name;
        Email = email;
        ID = id;
    }
}
