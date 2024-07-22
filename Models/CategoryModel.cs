using System.ComponentModel.DataAnnotations;

namespace ProjectEcommerce.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoeyID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string CategoryDescription { get; set; }
        public int DisplayOrder {  get; set; }
    }
}
