using Core.Validators;

namespace Domain.Entities;

public class Category
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public CategoryType Type { get; private set; }
    public DateTime RegistrationDate { get; private set; }

    protected Category() { }

    public Category(int id, string name, string description, CategoryType type, DateTime registrationDate)
    {
        EntityValidator.ValidateName(name);
        EntityValidator.ValidateDescription(description);

        Id = id;
        Name = name;
        Description = description;
        Type = type;
        RegistrationDate = registrationDate;
    }
    public void UpdateCategory(string name, string description, CategoryType type)
    {
        EntityValidator.ValidateName(name);
        EntityValidator.ValidateDescription(description);

        Name = name;
        Description = description;
        Type = type;
    }
}
public enum CategoryType
{
    Income,
    Expense
}    