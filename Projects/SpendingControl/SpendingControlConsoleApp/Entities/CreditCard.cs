using SpendingControlConsoleApp.Validators;

namespace SpendingControlConsoleApp.Entities
{
    public class CreditCard
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Brand { get; private set; } = string.Empty;
        public double Limit { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime RegistrationDate { get; set; }

        protected CreditCard() { }

        public CreditCard(int id, int userId, string name, DateTime expirationDate, string brand,
            double limit, DateTime dueDate, DateTime registrationDate)
        {
            EntityValidator.ValidateName(name);

            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Brand cannot be null or empty.", nameof(brand));
            if (brand.Length < CreditCardConstants.MinBrandLength || brand.Length > CreditCardConstants.MaxBrandLength)
                throw new ArgumentException(
                    $"Brand must be between {CreditCardConstants.MinBrandLength} and {CreditCardConstants.MaxBrandLength} characters.",
                    nameof(brand));

            Id = id;
            UserId = userId;
            Name = name;
            ExpirationDate = expirationDate;
            Brand = brand;
            Limit = limit;
            DueDate = dueDate;
            RegistrationDate = registrationDate;
        }
        public void UpdateCreditCard(string name, DateTime expirationDate, string brand,
            double limit, DateTime dueDate)
        {
            EntityValidator.ValidateName(name);

            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Brand cannot be null or empty.", nameof(brand));
            if (brand.Length < CreditCardConstants.MinBrandLength || brand.Length > CreditCardConstants.MaxBrandLength)
                throw new ArgumentException(
                    $"Brand must be between {CreditCardConstants.MinBrandLength} and {CreditCardConstants.MaxBrandLength} characters.",
                    nameof(brand));

            Name = name;
            ExpirationDate = expirationDate;
            Brand = brand;
            Limit = limit;
            DueDate = dueDate;
        }
    }

    public static class CreditCardConstants
    {
        public const int MinBrandLength = 2;
        public const int MaxBrandLength = 50;
    }
}
