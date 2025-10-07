namespace Lucas.ContentContext;

public class Career(string title, string url) : Content(title, url)
{
    public IList<CareerItem> Itens { get; set; } = [];
    public int TotalCourses => Itens.Count;
}
