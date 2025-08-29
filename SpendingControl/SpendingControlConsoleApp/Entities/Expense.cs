namespace SpendingControlConsoleApp.Entities
{
    public class Expense
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int CategoryId { get; private set; }
        public string? Description { get; private set; }
        public double Amount { get; private set; }
        public string PaymentMethod { get; private set; } = string.Empty;
        public DateTime Date { get; private set; }

        protected Expense() { }

        public Expense(int id, int userId, int categoryId, double amount, string paymentMethod, DateTime date, string? description = null)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.", nameof(amount));
            if (string.IsNullOrWhiteSpace(paymentMethod))
                throw new ArgumentException("Payment method cannot be null or empty.", nameof(paymentMethod));

            Id = id;
            UserId = userId;
            CategoryId = categoryId;
            Description = description;
            Amount = amount;
            PaymentMethod = paymentMethod;
            Date = date;
        }
        public void UpdateExpense(int categoryId, double amount, string paymentMethod, string? description = null)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.", nameof(amount));
            if (string.IsNullOrWhiteSpace(paymentMethod))
                throw new ArgumentException("Payment method cannot be null or empty.", nameof(paymentMethod));

            CategoryId = categoryId;
            Description = description;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }
    }

    public static class ExpenseConstants
    {
        public const int MinDescriptionLength = 5;
        public const int MaxDescriptionLength = 500;
    }
}