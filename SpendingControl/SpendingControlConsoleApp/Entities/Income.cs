namespace ControleGastosConsoleApp.Entities
{
    public class Income
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int CategoryId { get; private set; }
        public string Description { get; private set; } = string.Empty;
        public decimal Amount { get; private set; }
        public DateTime Date { get; private set; }

        protected Income() { }

        public Income(int id, int userId, int categoryId, string description, decimal amount, DateTime date)
        {
            Id = id;
            UserId = userId;
            CategoryId = categoryId;
            Description = description;
            Amount = amount;
            Date = date;
        }
    }
}
