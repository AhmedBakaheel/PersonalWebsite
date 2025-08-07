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
                    Title = "���� ����� ������ (Task Management System)",
                    Description = "����� ��� ���� ������ ������ ��������ڡ ���� ���������� ������ ����� ���ڡ ������ ������ �������.",
                    ImagePath = "/images/a.jpg", 
                    Technologies = new List<string> { "ASP.NET Core MVC", "C#", "Entity Framework Core", "SQL Server", "Bootstrap", "jQuery" },
                    GitHubLink = "https://github.com/AhmedBakaheel/ECommerce.git", 
                    LiveDemoLink = "https://yourdemolink.com/task-manager"
                },
                new Project
                {
                    Id = 2,
                    Title = "���� �������� ���� (E-commerce Mini-Store)",
                    Description = "���� ����� ��������� ����� ���� �������� ������ ������ʡ �� ����� ������ ����� ����� ���������.",
                    ImagePath = "/images/c.jpg",
                    Technologies = new List<string> { "ASP.NET Core Razor Pages", "C#", "SQL Server Express", "HTML", "CSS", "JavaScript" },
                    GitHubLink = "https://github.com/yourusername/ecommerce-mini-store",
                    LiveDemoLink = null
                },
                
                new Project
                {
                    Id = 3,
                    Title = "����� ����� ����� (Personal Blog App)",
                    Description = "����� ��� ���� ������ ������ �������� ������ɡ ���� ����� ����� ������ ������.",
                    ImagePath = "/images/d.jpg",
                    Technologies = new List<string> { "ASP.NET Core", "Razor Pages", "SQLite", "Bootstrap" },
                    GitHubLink = "https://github.com/yourusername/personal-blog",
                    LiveDemoLink = "https://yourblogdemo.com"
                }
            };
        }
    }
}