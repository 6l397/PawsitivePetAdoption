namespace PawsitivePetAdoption.Model;

public class Animals
{
    public int AnimalId { get; set; }
    public required string AnimalName { get; set; }
    public required string Species { get; set; }
    public required DateOnly DateOfBirth { get; set; }
    public required string Gender { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    
    public ICollection<Adoptions> Adoptions { get; set; }
    
}