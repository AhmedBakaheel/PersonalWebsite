namespace MyPortfolioApp.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public List<string> Technologies { get; set; } 
        public string GitHubLink { get; set; }
        public string LiveDemoLink { get; set; } 
    }
}