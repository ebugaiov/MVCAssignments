using System.ComponentModel.DataAnnotations;

namespace MVCAssignment5.Data;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Product Name is required")]
    [StringLength(100, ErrorMessage = "Product Name cannot be longer than 100 characters")]
    public required string Name { get; set; }
    
    [Required(ErrorMessage = "Price is required")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive number")]
    public required decimal Price { get; set; }
    
    public int Stock { get; set; }
}