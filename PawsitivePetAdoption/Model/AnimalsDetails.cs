using System.ComponentModel.DataAnnotations;

namespace PawsitivePetAdoption.Model;

public class AnimalsDetails
{
    public int AnimalId { get; set; }
    
    [Required]
    [StringLength(50)]
    public required string AnimalName { get; set; }
    
    [Required]
    public string Species { get; set; }
    
    [Required(ErrorMessage = "The DateOfBirth field is required")]
    
    public required DateOnly DateOfBirth { get; set; }
    
    [Required]
    public required string Gender { get; set; }
    
    [StringLength(200)]
    public string Description { get; set; }
    
    [Required]
    public string Status { get; set; }
    
    public ICollection<Adoptions> Adoptions { get; set; }
}