namespace Lucas.ContentContext;

public class Module
{
    public int Order { get; set; }
    public string Title { get; set; } = string.Empty;
    public IList<Lecture> Lectures { get; set; } = [];
}
