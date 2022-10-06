using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100 only.")]
        public int DisplayOrder { get; set; }

        public DateTime CreateDateTime { get; set; } = DateTime.Now;

        public static implicit operator Category(BulkyBook.DataAccess.Repository.CategoryRepository v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Category(BulkyBook.DataAccess.Repository.CategoryRepository v)
        {
            throw new NotImplementedException();
        }
    }
}
