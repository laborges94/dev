namespace SpendingControlConsoleApp.Validators
{
    public static class EntityValidator
    {
        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            if (name.Length < 2 || name.Length > 100)
                throw new ArgumentException("Name must be between 2 and 100 characters.", nameof(name));
        }

        public static void ValidateDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be null or empty.", nameof(description));
            if (description.Length < 5 || description.Length > 500)
                throw new ArgumentException("Description must be between 5 and 500 characters.", nameof(description));
        }

        public static void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email cannot be null or empty.", nameof(email));
            if (email.Length < 5 || email.Length > 100)
                throw new ArgumentException("Email must be between 5 and 100 characters.", nameof(email));
        }

        public static void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));
            if (password.Length < 6 || password.Length > 200)
                throw new ArgumentException("Password must be between 6 and 200 characters.", nameof(password));
        }
    }
}