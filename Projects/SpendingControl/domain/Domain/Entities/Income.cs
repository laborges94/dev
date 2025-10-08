using Core.Validators;

namespace Domain.Entities;

public class Income
{
    public int Id { get; private set; }
    public int UserId { get; private set; }
    public int CategoryId { get; private set; }
    public string? Description { get; private set; }
    public double Amount { get; private set; }
    public DateTime Date { get; private set; }

    protected Income() { }

    public Income(int id, int userId, int categoryId, double amount, DateTime date, string? description = null)
    {
        if (!string.IsNullOrWhiteSpace(description))
            EntityValidator.ValidateDescriptionLength(description);

        if (amount <= 0)
            throw new ArgumentException("Amount must be positive.", nameof(amount));

        Id = id;
        UserId = userId;
        CategoryId = categoryId;
        Description = description;
        Amount = amount;
        Date = date;
    }

    public void UpdateIncome(int categoryId, double amount, string? description = null)
    {
        if (!string.IsNullOrWhiteSpace(description))
            EntityValidator.ValidateDescriptionLength(description);

        if (amount <= 0)
            throw new ArgumentException("Amount must be positive.", nameof(amount));

        CategoryId = categoryId;
        Description = description;
        Amount = amount;
    }
}    
