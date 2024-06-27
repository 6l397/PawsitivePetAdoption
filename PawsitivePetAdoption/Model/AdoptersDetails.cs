using System.ComponentModel.DataAnnotations;

namespace PawsitivePetAdoption.Model;

public class AdoptersDetails
{
    public int Id { get; set; }
        
    [Required]
    [StringLength(25)]
    public string FirstName { get; set; }        
    
    [Required]
    [StringLength(25)]
    public string LastName { get; set; }
    
    [Required]
    [DataType(DataType.EmailAddress)]
    [EmailAddress]    
    public string Email { get; set; }
        
    [Required]
    public DateOnly DateOfBirth { get; set; }
    
    [Required]
    [Phone]
    public string Phone { get; set; }
    
    [Required]
    public string Address { get; set; }

    public ICollection<Adoptions> Adoptions { get; set; }
}