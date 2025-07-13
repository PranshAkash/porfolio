using Portfolio.Models;

namespace Portfolio.Services
{
    public class PortfolioService : IPortfolioService
    {
        public PersonalInfo GetPersonalInfo()
        {
            return new PersonalInfo();
        }

        public List<Experience> GetExperiences()
        {
            return new List<Experience>
            {
                new Experience
                {
                    JobTitle = "Software Developer",
                    Company = "Channel Fusion",
                    StartDate = new DateTime(2019, 2, 1),
                    Location = "Remote",
                    Responsibilities = new List<string>
                    {
                        "Built and deployed solutions using .NET Core, Razor Pages, and Docker for clients across incentive and rebate management domains.",
                        "Designed and integrated APIs and Webhooks to automate Certificate Renewal workflows, increasing efficiency by 30%.",
                        "Collaborated on MyExchange for processing external data via RESTful APIs with custom authentication.",
                        "Developed full e-commerce platform Shopg9, including admin/vendor dashboards and product/order workflows.",
                        "Engineered data-driven health card generation for NGO project Arogya India, including admin-volunteer management with dynamic UI.",
                        "Contributed to CustomHome.ai platform, integrating Revit tools for 3D architecture planning with dynamic UI."
                    },
                    Technologies = new List<string> { ".NET Core", "C#", "React", "Razor Pages", "Docker", "Kubernetes", "Azure", "SQL Server", "RESTful APIs" }
                }
            };
        }

        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Title = "SAAS (Tailored)",
                    Description = "Comprehensive modular SaaS platform for client task automation with reduced manual entry.",
                    StartDate = new DateTime(2023, 1, 1),
                    Technologies = new List<string> { ".NET Core", "Razor Pages", "jQuery", "MS SQL", "Docker" },
                    KeyFeatures = new List<string>
                    {
                        "Modular architecture for customization",
                        "Automated task workflows",
                        "Client-specific configurations",
                        "Real-time dashboard analytics"
                    }
                },
                new Project
                {
                    Title = "Certificate Renewal System",
                    Description = "Automated document parsing and rendering system using Webhooks and scheduled background services.",
                    StartDate = new DateTime(2022, 6, 1),
                    EndDate = new DateTime(2023, 12, 1),
                    Technologies = new List<string> { ".NET MVC", "Webhooks", "Windows Services", "MS SQL" },
                    KeyFeatures = new List<string>
                    {
                        "PDF document parsing",
                        "Automated renewal workflows",
                        "Background service processing",
                        "Webhook integrations"
                    }
                },
                new Project
                {
                    Title = "MyExchange",
                    Description = "API-driven data ingestion and transformation platform with custom authentication.",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = new DateTime(2022, 12, 1),
                    Technologies = new List<string> { "MVC", "JSON", "REST API", "Entity Framework" },
                    KeyFeatures = new List<string>
                    {
                        "External API integrations",
                        "Data transformation pipelines",
                        "Custom authentication system",
                        "Real-time data processing"
                    }
                },
                new Project
                {
                    Title = "Shopg9 E-commerce",
                    Description = "Full-featured e-commerce platform with admin/vendor portals and order management.",
                    StartDate = new DateTime(2021, 3, 1),
                    EndDate = new DateTime(2022, 6, 1),
                    Technologies = new List<string> { "ASP.NET Core", "Entity Framework Core", "MSSQL", "Azure DevOps" },
                    KeyFeatures = new List<string>
                    {
                        "Multi-vendor marketplace",
                        "Order management system",
                        "Payment gateway integration",
                        "Admin dashboard with analytics"
                    }
                },
                new Project
                {
                    Title = "Arogya India Health Platform",
                    Description = "Health card generation platform with user registration and volunteer tracking systems.",
                    StartDate = new DateTime(2020, 6, 1),
                    EndDate = new DateTime(2021, 2, 1),
                    Technologies = new List<string> { "ASP.NET Core (Code First)", "JSON", "Ajax" },
                    KeyFeatures = new List<string>
                    {
                        "Digital health card generation",
                        "Volunteer management system",
                        "User registration workflows",
                        "Dynamic reporting interface"
                    }
                },
                new Project
                {
                    Title = "CustomHome.ai",
                    Description = "3D architectural planning interface for customers with Revit tool integrations.",
                    StartDate = new DateTime(2019, 9, 1),
                    EndDate = new DateTime(2020, 5, 1),
                    Technologies = new List<string> { "ASP.NET Core (DB First)", "Revit", "Ajax", "JSON", "Azure" },
                    KeyFeatures = new List<string>
                    {
                        "3D visualization tools",
                        "Revit API integration",
                        "Customer design interface",
                        "Real-time collaboration features"
                    }
                }
            };
        }

        public List<Skill> GetSkills()
        {
            return new List<Skill>
            {
                // Programming Languages
                new Skill { Name = "C#", Category = SkillCategory.Programming, Proficiency = 95, Icon = "devicon-csharp-plain" },
                new Skill { Name = ".NET Core", Category = SkillCategory.Framework, Proficiency = 90, Icon = "devicon-dotnetcore-plain" },
                new Skill { Name = "ASP.NET MVC", Category = SkillCategory.Framework, Proficiency = 85, Icon = "devicon-dot-net-plain" },
                new Skill { Name = "ReactJS", Category = SkillCategory.Framework, Proficiency = 80, Icon = "devicon-react-original" },
                new Skill { Name = "NextJS", Category = SkillCategory.Framework, Proficiency = 75, Icon = "devicon-nextjs-original" },
                new Skill { Name = "JavaScript", Category = SkillCategory.Programming, Proficiency = 85, Icon = "devicon-javascript-plain" },
                new Skill { Name = "TypeScript", Category = SkillCategory.Programming, Proficiency = 80, Icon = "devicon-typescript-plain" },
                new Skill { Name = "HTML", Category = SkillCategory.Programming, Proficiency = 90, Icon = "devicon-html5-plain" },
                new Skill { Name = "CSS", Category = SkillCategory.Programming, Proficiency = 85, Icon = "devicon-css3-plain" },
                new Skill { Name = "Bootstrap", Category = SkillCategory.Framework, Proficiency = 85, Icon = "devicon-bootstrap-plain" },
                new Skill { Name = "jQuery", Category = SkillCategory.Framework, Proficiency = 80, Icon = "devicon-jquery-plain" },
                
                // Databases
                new Skill { Name = "MS SQL Server", Category = SkillCategory.Database, Proficiency = 85, Icon = "devicon-microsoftsqlserver-plain" },
                new Skill { Name = "MySQL", Category = SkillCategory.Database, Proficiency = 80, Icon = "devicon-mysql-plain" },
                new Skill { Name = "Azure SQL Database", Category = SkillCategory.Database, Proficiency = 75, Icon = "devicon-azure-plain" },
                
                // DevOps & Tools
                new Skill { Name = "Docker", Category = SkillCategory.DevOps, Proficiency = 80, Icon = "devicon-docker-plain" },
                new Skill { Name = "Kubernetes", Category = SkillCategory.DevOps, Proficiency = 75, Icon = "devicon-kubernetes-plain" },
                new Skill { Name = "Azure DevOps", Category = SkillCategory.DevOps, Proficiency = 80, Icon = "devicon-azure-plain" },
                new Skill { Name = "GitHub", Category = SkillCategory.Tools, Proficiency = 85, Icon = "devicon-github-original" },
                new Skill { Name = "TFS", Category = SkillCategory.Tools, Proficiency = 75, Icon = "devicon-visualstudio-plain" },
                new Skill { Name = "Bitbucket", Category = SkillCategory.Tools, Proficiency = 70, Icon = "devicon-bitbucket-original" },
                new Skill { Name = "Jira", Category = SkillCategory.Tools, Proficiency = 75, Icon = "devicon-jira-plain" },
                new Skill { Name = "Azure Active Directory", Category = SkillCategory.Cloud, Proficiency = 70, Icon = "devicon-azure-plain" },
                
                // Cloud & AI
                new Skill { Name = "Large Language Models (LLMs)", Category = SkillCategory.Cloud, Proficiency = 70, Icon = "fa-solid fa-brain" },
                new Skill { Name = "AI-based IDEs", Category = SkillCategory.Tools, Proficiency = 75, Icon = "fa-solid fa-robot" }
            };
        }

        public List<Education> GetEducation()
        {
            return new List<Education>
            {
                new Education
                {
                    Degree = "Diploma in Information Technology",
                    Institution = "CSJM Govt. Polytechnic – BTEUP",
                    Location = "Lucknow, India",
                    StartDate = new DateTime(2016, 7, 1),
                    EndDate = new DateTime(2019, 6, 1),
                    Percentage = "70%"
                },
                new Education
                {
                    Degree = "Intermediate",
                    Institution = "St. Antony's Inter College – ICSE",
                    Location = "Lucknow, India",
                    StartDate = new DateTime(2014, 4, 1),
                    EndDate = new DateTime(2016, 3, 1),
                    Percentage = "68%"
                },
                new Education
                {
                    Degree = "High School",
                    Institution = "St. Antony's Inter College – ICSE",
                    Location = "Lucknow, India",
                    StartDate = new DateTime(2012, 4, 1),
                    EndDate = new DateTime(2014, 3, 1),
                    Percentage = "78.8%"
                }
            };
        }
    }
}
