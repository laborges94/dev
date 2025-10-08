using Lucas.ContentContext;

namespace Lucas.SubscriptionContext;

public class Subscription : Base
{
    public Plan Plan { get; set; } = null!;
    public DateTime? EndDate { get; set; }
    public bool IsActive => EndDate == null || EndDate > DateTime.Now;
}
