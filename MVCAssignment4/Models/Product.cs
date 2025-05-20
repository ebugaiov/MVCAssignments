using System.ComponentModel.DataAnnotations;

namespace MVCAssignment4.Models;

public class Product
{
    public int ProductId { get; set; }
    
    [Required(ErrorMessage = "Please enter a product name.")]
    [Display(Name = "Product Name")]
    public required string ProductName { get; set; }
    
    [Required(ErrorMessage = "Please enter a product price.")]
    [Display(Name = "Product Price")]
    public required decimal ProductPrice { get; set; }
    
    [Display(Name = "Product Description")]
    public string? ProductDescription { get; set; }
}
