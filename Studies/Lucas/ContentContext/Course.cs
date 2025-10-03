using Lucas.ContentContext.Enums;

namespace Lucas.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = [];
        }

        public string Tag { get; set; } = string.Empty;
        public int DurationInMinutes { get; set; }
        public ContentLevel Level { get; set; }
        public IList<Module> Modules { get; set; }
    }    
}
