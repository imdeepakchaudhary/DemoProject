using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class CategoryModel
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string status { get; set; }
    }
}
