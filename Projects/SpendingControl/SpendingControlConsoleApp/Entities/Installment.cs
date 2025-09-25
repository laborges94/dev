namespace SpendingControlConsoleApp.Entities
{
    public class Installment
    {
        public int ExpenseId { get; private set; }
        public int InstallmentNumber { get; private set; }
        public double Amount { get; private set; }
        public DateTime DueDate { get; private set; }
        public bool IsPaid { get; private set; }

        protected Installment() { }

        public Installment(int expenseId, int installmentNumber, double amount, DateTime dueDate, bool isPaid = false)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.", nameof(amount));

            ExpenseId = expenseId;
            InstallmentNumber = installmentNumber;
            Amount = amount;
            DueDate = dueDate;
            IsPaid = isPaid;
        }

        public void MarkAsPaid() => IsPaid = true;
    }
}