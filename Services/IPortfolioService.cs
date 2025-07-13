using Portfolio.Models;

namespace Portfolio.Services
{
    public interface IPortfolioService
    {
        PersonalInfo GetPersonalInfo();
        List<Experience> GetExperiences();
        List<Project> GetProjects();
        List<Skill> GetSkills();
        List<Education> GetEducation();
    }
}
