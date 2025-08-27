namespace ControleGastosConsoleApp.Entities
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public string Type { get; private set; } = string.Empty;
        public DateTime RegistrationDate { get; private set; }

        protected Category() { }

        public Category(int id, string name, string description, string type, DateTime registrationDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            RegistrationDate = registrationDate;
        }
    }
}