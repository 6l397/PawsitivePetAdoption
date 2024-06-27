namespace PawsitivePetAdoption.Model;

public class Adoptions
{
    public int AdoptionsId { get; set; }
    public Adopters Adopter { get; set; }
    public int AnimalId { get; set; }
    public Animals Animal { get; set; }
    public int AdopterId { get; set; }
    public DateTime AdoptionDate { get; set; }
}