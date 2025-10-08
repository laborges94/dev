using Lucas.ContentContext;
using Lucas.NotificationContext;

namespace Lucas.SubscriptionContext;

public class Student : Base
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public User User { get; set; } = null!;
    public IList<Subscription> Subscriptions { get; set; } = [];
    public void AddSubscription(Subscription subscription)
    {
        if (IsPremium)
            AddNotification(new Notification(
                "Student.Subscriptions", "You already have an active subscription"));
        else if (subscription.IsActive)
            Subscriptions.Add(subscription);
        else
            AddNotification(new Notification(
                "Student.Subscriptions", "This subscription is not active"));
    }
    public bool IsPremium => Subscriptions.Any(x => x.EndDate == null || x.EndDate > DateTime.Now);
}
