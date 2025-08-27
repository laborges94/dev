namespace ControleGastosConsoleApp.Entities
{
    public class FinancialGoal
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public decimal GoalAmount { get; private set; }
        public decimal CurrentAmount { get; private set; }
        public DateTime Deadline { get; private set; }

        protected FinancialGoal() { }

        public FinancialGoal(int id, int userId, string name, decimal goalAmount, decimal currentAmount,
            DateTime deadline, string description)
        {
            Id = id;
            UserId = userId;
            Name = name;
            GoalAmount = goalAmount;
            CurrentAmount = currentAmount;
            Deadline = deadline;
            Description = description;
        }
    }
}
