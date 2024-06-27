using Microsoft.EntityFrameworkCore;
using PawsitivePetAdoption.Data;
using PawsitivePetAdoption.Model;

namespace PawsitivePetAdoption.Controllers;

public class UsersController
{
    private readonly AppDbContext _context;

    public UsersController(AppDbContext dbContext)
    {
        _context = dbContext;
    }

    public async Task AddUserAsync(Adopters newUser)
    {
        _context.Adopters.Add(newUser);
        await _context.SaveChangesAsync();
    }
    public async Task<Adopters> GetUserByIdAsync(int userId)
    {
        return await _context.Adopters.FindAsync(userId);
    }

    public async Task<IEnumerable<Adopters>> GetUsersAsync()
    {
        return await _context.Adopters.ToListAsync();
    }
}