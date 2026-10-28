using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public required string Title { get; set; }
        
        [Required]
        public required string Description { get; set; }
        
        public string? ImageUrl { get; set; }
        
        // Kullanılan teknolojileri virgülle ayırarak tutabiliriz (Örn: ".NET 8, Bootstrap, Azure")
        public string? TechStack { get; set; } 
        
        public string? ProjectUrl { get; set; }
        
        public string? GitHubUrl { get; set; }
    }
}