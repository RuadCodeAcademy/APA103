using _27_FrontToBackSqlConnection.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace _27_FrontToBackSqlConnection.Models
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(30, ErrorMessage = "Agilli ol")]
        public string? Name { get; set; }

        public List<Product>? Products { get; set; }


    }
}
