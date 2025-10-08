using Core.Validators;

namespace Domain.Entities;

public class FinancialGoal
{
    public int Id { get; private set; }
    public int UserId { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public double GoalAmount { get; private set; }
    public double CurrentAmount { get; private set; }
    public DateTime Deadline { get; private set; }
    public DateTime RegistrationDate { get; set; }

    protected FinancialGoal() { }

    public FinancialGoal(int id, int userId, string name, double goalAmount, double currentAmount,
        DateTime deadline, string description, DateTime registrationDate)
    {
        EntityValidator.ValidateName(name);
        EntityValidator.ValidateDescription(description);

        Id = id;
        UserId = userId;
        Name = name;
        GoalAmount = goalAmount;
        CurrentAmount = currentAmount;
        Deadline = deadline;
        Description = description;
        RegistrationDate = registrationDate;
    }
    public void UpdateFinancialGoal(string name, double goalAmount, double currentAmount,
        DateTime deadline, string description)
    {
        Name = name;
        GoalAmount = goalAmount;
        CurrentAmount = currentAmount;
        Deadline = deadline;
        Description = description;
    }
}    
