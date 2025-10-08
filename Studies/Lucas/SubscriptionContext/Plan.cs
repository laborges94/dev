using Lucas.ContentContext;

namespace Lucas.SubscriptionContext;

public class Plan : Base
{
    public string Title { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int DurationInDays { get; set; }
}
