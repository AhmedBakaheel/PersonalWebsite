using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPortfolioApp.Models;

namespace MyPortfolioApp.Pages.Projects
{
    public class IndexModel : PageModel
    {
        public List<Project> Projects { get; set; }

        public void OnGet()
        {
           
            Projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "‰Ÿ«„ ≈œ«—… «·„Â«„ (Task Management System)",
                    Description = " ÿ»Ìﬁ ÊÌ» ‘«„· ·≈œ«—… «·„Â«„ Ê«·„‘«—Ì⁄° Ì ÌÕ ··„” Œœ„Ì‰ ≈‰‘«¡°  ⁄ÌÌ‰°   »⁄° Ê≈ﬂ„«· «·„Â«„ »›⁄«·Ì….",
                    ImagePath = "/images/a.jpg", 
                    Technologies = new List<string> { "ASP.NET Core MVC", "C#", "Entity Framework Core", "SQL Server", "Bootstrap", "jQuery" },
                    GitHubLink = "https://github.com/AhmedBakaheel/ECommerce.git", 
                    LiveDemoLink = "https://yourdemolink.com/task-manager"
                },
                new Project
                {
                    Id = 2,
                    Title = "„ Ã— ≈·ﬂ —Ê‰Ì »”Ìÿ (E-commerce Mini-Store)",
                    Description = "„‰’…  Ã«—… ≈·ﬂ —Ê‰Ì… Œ›Ì›… ·⁄—÷ «·„‰ Ã«  Ê≈œ«—… «·ÿ·»« ° „⁄ Ê«ÃÂ… „” Œœ„ ‰ŸÌ›… Ê”Â·… «·«” Œœ«„.",
                    ImagePath = "/images/c.jpg",
                    Technologies = new List<string> { "ASP.NET Core Razor Pages", "C#", "SQL Server Express", "HTML", "CSS", "JavaScript" },
                    GitHubLink = "https://github.com/yourusername/ecommerce-mini-store",
                    LiveDemoLink = null
                },
                
                new Project
                {
                    Id = 3,
                    Title = " ÿ»Ìﬁ „œÊ‰… ‘Œ’Ì… (Personal Blog App)",
                    Description = " ÿ»Ìﬁ ÊÌ» »”Ìÿ ·≈‰‘«¡ Ê≈œ«—… «·„ﬁ«·«  «·‘Œ’Ì…° Ìœ⁄„ ≈÷«›… «·’Ê— Ê ‰”Ìﬁ «·‰’Ê’.",
                    ImagePath = "/images/d.jpg",
                    Technologies = new List<string> { "ASP.NET Core", "Razor Pages", "SQLite", "Bootstrap" },
                    GitHubLink = "https://github.com/yourusername/personal-blog",
                    LiveDemoLink = "https://yourblogdemo.com"
                }
            };
        }
    }
}