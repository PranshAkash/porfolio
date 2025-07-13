namespace Portfolio.Models
{
    public class Experience
    {
        public string JobTitle { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public List<string> Responsibilities { get; set; } = new();
        public List<string> Achievements { get; set; } = new();
        public List<string> Technologies { get; set; } = new();
        public bool IsCurrent => EndDate == null;
        public string Duration => IsCurrent ? 
            $"{StartDate:MMM yyyy} - Present" : 
            $"{StartDate:MMM yyyy} - {EndDate:MMM yyyy}";
    }
}
