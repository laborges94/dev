using SpendingControlConsoleApp.Validators;

namespace SpendingControlConsoleApp.Entities
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
            EntityValidator.ValidateName(name);
            EntityValidator.ValidateEmail(email);
            EntityValidator.ValidatePassword(password);

            Id = id;
            Name = name;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
        }

        public void UpdatePersonalInfo(string name, string email)
        {
            EntityValidator.ValidateName(name);
            EntityValidator.ValidateEmail(email);

            Name = name;
            Email = email;
        }

        public void UpdatePassword(string password)
        {
            EntityValidator.ValidatePassword(password);

            Password = password;
        }        
    }    
}