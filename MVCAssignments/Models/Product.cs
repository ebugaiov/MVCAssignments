using System.ComponentModel.DataAnnotations;

namespace MVCAssignments.Models;

public class Product
{
    public int ProductId { get; set; }
    
    [Required(ErrorMessage = "Please enter a product name.")]
    [Display(Name = "Product Name")]
    public string ProductName { get; set; }
    
    [Required(ErrorMessage = "Please enter a product price.")]
    [Display(Name = "Product Price")]
    public decimal ProductPrice { get; set; }
    
    [Required(ErrorMessage = "Please enter a product description.")]
    [Display(Name = "Product Description")]
    public string ProductDescription { get; set; }
}
