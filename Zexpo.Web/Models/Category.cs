using System.ComponentModel.DataAnnotations;

namespace Zexpo.Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = null!;
        public string? Note {  get; set; } 
        public DateTime Orderdate { get; set; } = DateTime.Now;

    }
}
