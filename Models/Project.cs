namespace Portfolio.Models
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Technologies { get; set; } = new();
        public string? GitHubUrl { get; set; }
        public string? LiveUrl { get; set; }
        public string ImageUrl { get; set; } = "/images/project-placeholder.jpg";
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> KeyFeatures { get; set; } = new();
    }
}
