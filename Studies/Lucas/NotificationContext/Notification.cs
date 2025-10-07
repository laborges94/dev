namespace Lucas.NotificationContext;

public sealed class Notification(string property, string message)
{
    public string Property { get; set; } = property;
    public string Message { get; set; } = message;
    public DateTime Date { get; set; } = DateTime.Now;
}