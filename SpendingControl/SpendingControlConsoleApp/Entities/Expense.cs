using SpendingControlConsoleApp.Validators;

namespace SpendingControlConsoleApp.Entities
{
    public class Expense
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int CategoryId { get; private set; }
        public int? CreditCardId { get; set; }
        public string? Description { get; private set; }
        public double Amount { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public DateTime Date { get; private set; }

        protected Expense() { }

        public Expense(int id, int userId, int categoryId, double amount, PaymentMethod paymentMethod, DateTime date, string? description = null, int? creditCardId = null)
        {
            if (!string.IsNullOrWhiteSpace(description))
                EntityValidator.ValidateDescriptionLength(description);

            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.", nameof(amount));

            Id = id;
            UserId = userId;
            CategoryId = categoryId;
            CreditCardId = creditCardId;
            Description = description;
            Amount = amount;
            PaymentMethod = paymentMethod;
            Date = date;
        }
        public void UpdateExpense(int categoryId, double amount, PaymentMethod paymentMethod, string? description = null, int? creditCardId = null)
        {
            if (!string.IsNullOrWhiteSpace(description))
                EntityValidator.ValidateDescriptionLength(description);

            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.", nameof(amount));

            CategoryId = categoryId;
            Description = description;
            Amount = amount;
            PaymentMethod = paymentMethod;
            CreditCardId = creditCardId;
        }
    }    
    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        DebitCard,
        BankTransfer,
        Other
    }
}