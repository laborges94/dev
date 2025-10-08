using Lucas.NotificationContext;

namespace Lucas.ContentContext;
public abstract class Base : Notifiable
{
    public Guid Id { get; set; } = Guid.NewGuid();
}