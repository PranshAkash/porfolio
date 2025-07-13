namespace Portfolio.Models
{
    public class Education
    {
        public string Degree { get; set; } = string.Empty;
        public string Institution { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Percentage { get; set; }
        public List<string> Subjects { get; set; } = new();
    }
}
