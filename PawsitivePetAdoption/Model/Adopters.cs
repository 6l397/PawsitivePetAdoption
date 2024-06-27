namespace PawsitivePetAdoption.Model;

public class Adopters
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required DateOnly DateOfBirth { get; set; }
    public required string Phone  { get; set; }
    public required string Address  { get; set; }
    
    public ICollection<Adoptions> Adoptions { get; set; }
}