namespace SpendingControlConsoleApp.Entities
{
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
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            if (name.Length < FinancialGoalConstants.MinNameLength || name.Length > FinancialGoalConstants.MaxNameLength)
                throw new ArgumentException(
                    $"Name must be between {FinancialGoalConstants.MinNameLength} and {FinancialGoalConstants.MaxNameLength} characters.",
                    nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be null or empty.", nameof(description));
            if (description.Length < FinancialGoalConstants.MinDescriptionLength || description.Length > FinancialGoalConstants.MaxDescriptionLength)
                throw new ArgumentException(
                    $"Description must be between {FinancialGoalConstants.MinDescriptionLength} and {FinancialGoalConstants.MaxDescriptionLength} characters.",
                    nameof(description));
                    
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

    public static class FinancialGoalConstants
    {
        public const int MinNameLength = 2;
        public const int MaxNameLength = 100;
        public const int MinDescriptionLength = 5;
        public const int MaxDescriptionLength = 500;
    }
}
