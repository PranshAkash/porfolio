namespace Portfolio.Models
{
    public class Skill
    {
        public string Name { get; set; } = string.Empty;
        public SkillCategory Category { get; set; }
        public int Proficiency { get; set; } // 1-100
        public string Icon { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public enum SkillCategory
    {
        Programming,
        Framework,
        Database,
        DevOps,
        Cloud,
        Tools
    }
}
