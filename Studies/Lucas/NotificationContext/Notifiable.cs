namespace Lucas.NotificationContext;
public abstract class Notifiable
{
    public IList<Notification> Notifications { get; set; } = [];

    public void AddNotification(Notification notification)
        => Notifications.Add(notification);

    public void AddNotifications(IList<Notification> notifications)
    {
        foreach (var notification in notifications)
            AddNotification(notification);
    }

    public bool IsValid => !Notifications.Any();
}