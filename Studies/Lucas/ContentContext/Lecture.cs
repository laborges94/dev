using Lucas.ContentContext.Enums;

namespace Lucas.ContentContext;

public class Lecture
{
    public int Order { get; set; }
    public string Title { get; set; } = string.Empty;
    public int DurationInMinutes { get; set; }
    public ContentLevel Level { get; set; }
}
