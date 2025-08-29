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
            
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            if (name.Length < UserConstants.MinNameLength || name.Length > UserConstants.MaxNameLength)
                throw new ArgumentException(
                    $"Name must be between {UserConstants.MinNameLength} and {UserConstants.MaxNameLength} characters.",
                    nameof(name));

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email cannot be null or empty.", nameof(email));
            if (email.Length < UserConstants.MinEmailLength || email.Length > UserConstants.MaxEmailLength)
                throw new ArgumentException(
                    $"Email must be between {UserConstants.MinEmailLength} and {UserConstants.MaxEmailLength} characters.",
                    nameof(email));

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));
            if (password.Length < UserConstants.MinPasswordLength || password.Length > UserConstants.MaxPasswordLength)
                throw new ArgumentException(
                    $"Password must be between {UserConstants.MinPasswordLength} and {UserConstants.MaxPasswordLength} characters.",
                    nameof(password));

            Id = id;
            Name = name;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
        }

        public void UpdatePersonalInfo(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            if (name.Length < UserConstants.MinNameLength || name.Length > UserConstants.MaxNameLength)
                throw new ArgumentException(
                    $"Name must be between {UserConstants.MinNameLength} and {UserConstants.MaxNameLength} characters.",
                    nameof(name));

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email cannot be null or empty.", nameof(email));
            if (email.Length < UserConstants.MinEmailLength || email.Length > UserConstants.MaxEmailLength)
                throw new ArgumentException(
                    $"Email must be between {UserConstants.MinEmailLength} and {UserConstants.MaxEmailLength} characters.",
                    nameof(email));

            Name = name;
            Email = email;
        }

        public void UpdatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));
            if (password.Length < UserConstants.MinPasswordLength || password.Length > UserConstants.MaxPasswordLength)
                throw new ArgumentException(
                    $"Password must be between {UserConstants.MinPasswordLength} and {UserConstants.MaxPasswordLength} characters.",
                    nameof(password));

            Password = password;
        }
    }

    public static class UserConstants
    {
        public const int MinNameLength = 2;
        public const int MaxNameLength = 100;
        public const int MinEmailLength = 5;
        public const int MaxEmailLength = 100;
        public const int MinPasswordLength = 6;
        public const int MaxPasswordLength = 200;
    }
}