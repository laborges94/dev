namespace ControleGastosConsoleApp.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;
        public DateTime RegistrationDate { get; private set; }

        protected User() { }

        public User(int id, string name, string email, string password, DateTime registrationDate)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
        }
    }
}