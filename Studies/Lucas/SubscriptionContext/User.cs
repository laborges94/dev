using Lucas.ContentContext;

namespace Lucas.SubscriptionContext;

public class User(string userName, string password) : Base
{
    public string UserName { get; set; } = userName;
    public string Password { get; set; } = password;
}