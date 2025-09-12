using SpendingControlConsoleApp.Validators;

namespace SpendingControlConsoleApp.Entities
{
    public class Expense
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int CategoryId { get; private set; }
        public int? CreditCardId { get; private set; }
        public string? Description { get; private set; }
        public double Amount { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public PaymentCondition PaymentCondition { get; private set; }
        public int Installments { get; private set; }
        public DateTime Date { get; private set; }
        private readonly List<Installment> _installmentsList = [];
        public IReadOnlyCollection<Installment> InstallmentsList => _installmentsList.AsReadOnly();

        protected Expense() { }

        public Expense(int id, int userId, int categoryId, double amount, PaymentMethod paymentMethod,
        PaymentCondition paymentCondition, int installments, DateTime date, string? description = null, int? creditCardId = null)
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
            Installments = installments;
        }

        public void UpdateExpense(int categoryId, double amount, PaymentMethod paymentMethod, int installments,
        PaymentCondition paymentCondition, string? description = null, int? creditCardId = null)
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
            Installments = installments;
        }

        public void SetInstallments(int installments, List<Installment> installmentsList)
        {
            if (installmentsList == null || installmentsList.Count != installments)
                throw new ArgumentException("Installments list must match the number of installments.", nameof(installmentsList));

            Installments = installments;
            _installmentsList.Clear();
            _installmentsList.AddRange(installmentsList);
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