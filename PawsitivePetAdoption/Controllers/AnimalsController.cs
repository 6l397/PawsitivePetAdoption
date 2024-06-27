using Microsoft.EntityFrameworkCore;
using PawsitivePetAdoption.Data;
using PawsitivePetAdoption.Model;

namespace PawsitivePetAdoption.Controllers;

public class AnimalsController
{
    private readonly AppDbContext _context;

    public AnimalsController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Animals>> GetAnimalsAsync()
    {
        return await _context.Animals.ToListAsync();
    }

    public async Task<Animals> GetAnimalAsync(int id)
    {
        return await _context.Animals.FirstOrDefaultAsync(a => a.AnimalId == id);
    }

    public async Task AddAnimalAsync(Animals animal)
    {
        _context.Animals.Add(animal);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAnimalAsync(Animals animal)
    {
        _context.Entry(animal).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAnimalAsync(int id)
    {
        var animal = await _context.Animals.FindAsync(id);
        if (animal != null)
        {
            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Animals>> GetDogsAsync()
    {
        return await _context.Animals.Where(a => a.Species == "dog").ToListAsync();
    }

    public async Task<IEnumerable<Animals>> GetCatsAsync()
    {
        return await _context.Animals.Where(a => a.Species == "cat").ToListAsync();
    }

    public async Task AdoptAnimalAsync(int adopterId, int animalId)
    {
        var adoption = new Adoptions
        {
            AdopterId = adopterId,
            AnimalId = animalId,
            AdoptionDate = DateTime.UtcNow
        };
        _context.Adoptions.Add(adoption);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Adoptions>> GetAdoptionsAsync()
    {
        return await _context.Adoptions
            .Include(a => a.Animal)
            .Include(a => a.Adopter)
            .ToListAsync();
    }
}