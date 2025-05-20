using System.ComponentModel.DataAnnotations;

namespace MVCAssignment5.Data;

public class Customer
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "First Name is required")]
    [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters")]
    public required string FirstName { get; set; }
    
    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(50, ErrorMessage = "Last Name cannot be longer than 50 characters")]
    public required string LastName { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters")]
    public required string Email { get; set; }
}