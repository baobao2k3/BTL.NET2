using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVC.Models
{
    public class Product
    {
        [Key] //Khóa chính
        public int  Id { get; set; }
        public string? Name { get; set; }
        public string ?Description { get; set; }
        public decimal Price { get; set; }
            
        public int Quantity { get; set; }
        public string? ImageUrl { get; set; }
        [ForeignKey("Category")]//Khóa ngoài
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; } //Điều hướng
    }
}
