namespace ControleGastosConsoleApp.Entities
{
    public class Expense
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int CategoryId { get; private set; }
        public string Description { get; private set; } = string.Empty;
        public decimal Amount { get; private set; }
        public string PaymentMethod { get; private set; } = string.Empty;
        public DateTime Date { get; private set; }

        protected Expense() { }

        public Expense(int id, int userId, int categoryId, string description, decimal amount, string paymentMethod, DateTime date)
        {
            Id = id;
            UserId = userId;
            CategoryId = categoryId;
            Description = description;
            Amount = amount;
            PaymentMethod = paymentMethod;
            Date = date;
        }
    }
}