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
        public PaymentCondition PaymentCondition { get; private set; }
        public int Installments { get; private set; } = 1;
        public DateTime Date { get; private set; }

        protected Expense() { }

        public Expense(int id, int userId, int categoryId, double amount, PaymentMethod paymentMethod, PaymentCondition paymentCondition, DateTime date, string? description = null, int? creditCardId = null)
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
            PaymentCondition = paymentCondition;
            Date = date;
        }
        public void UpdateExpense(int categoryId, double amount, PaymentMethod paymentMethod, PaymentCondition paymentCondition, string? description = null, int? creditCardId = null)
        {
            if (!string.IsNullOrWhiteSpace(description))
                EntityValidator.ValidateDescriptionLength(description);

            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.", nameof(amount));

            CategoryId = categoryId;
            Description = description;
            Amount = amount;
            PaymentMethod = paymentMethod;
            PaymentCondition = paymentCondition;
            CreditCardId = creditCardId;
        }
    }

    public enum PaymentCondition
    {
        InCash,
        Installments
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