namespace ReferenceArchitecture.Domain.Companies;

public class Company
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public Company(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}