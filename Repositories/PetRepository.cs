
public class PetRepository : IPetRepository
{
    public readonly AppDbContext _context;

    public PetRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Pet> AddAsync(Pet pet)
    {
        _context.Pets.Add(pet);
        await _context.SaveChangesAsync();
        return pet;
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Pet>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Pet?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Pet pet)
    {
        throw new NotImplementedException();
    }
}
