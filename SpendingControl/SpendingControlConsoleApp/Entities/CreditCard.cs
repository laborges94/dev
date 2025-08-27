namespace ControleGastosConsoleApp.Entities
{
    public class CreditCard
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Brand { get; private set; } = string.Empty;
        public decimal Limit { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public DateTime DueDate { get; private set; }

        protected CreditCard() { }

        public CreditCard(int id, int userId, string name, DateTime expirationDate, string brand,
            decimal limit, DateTime dueDate)
        {
            Id = id;
            UserId = userId;
            Name = name;
            ExpirationDate = expirationDate;
            Brand = brand;
            Limit = limit;
            DueDate = dueDate;
        }
    }
}
