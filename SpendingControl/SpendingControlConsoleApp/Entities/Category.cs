using SpendingControlConsoleApp.Validators;
namespace SpendingControlConsoleApp.Entities
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
            EntityValidator.ValidateName(name);
            EntityValidator.ValidateDescription(description);

            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Type cannot be null or empty.", nameof(type));

            Id = id;
            Name = name;
            Description = description;
            Type = type;
            RegistrationDate = registrationDate;
        }
        public void UpdateCategory(string name, string description, string type)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));
            if (name.Length < CategoryConstants.MinNameLength || name.Length > CategoryConstants.MaxNameLength)
                throw new ArgumentException(
                    $"Name must be between {CategoryConstants.MinNameLength} and {CategoryConstants.MaxNameLength} characters.",
                    nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Description cannot be null or empty.", nameof(description));
            if (description.Length < CategoryConstants.MinDescriptionLength || description.Length > CategoryConstants.MaxDescriptionLength)
                throw new ArgumentException(
                    $"Description must be between {CategoryConstants.MinDescriptionLength} and {CategoryConstants.MaxDescriptionLength} characters.",
                    nameof(description));

            if (string.IsNullOrWhiteSpace(type))
                throw new ArgumentException("Type cannot be null or empty.", nameof(type));

            Name = name;
            Description = description;
            Type = type;
        }
    }

    public static class CategoryConstants
    {
        public const int MinNameLength = 2;
        public const int MaxNameLength = 100;
        public const int MinDescriptionLength = 5;
        public const int MaxDescriptionLength = 500;
    }
}