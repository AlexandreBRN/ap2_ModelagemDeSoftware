
public class PetService : IPetService
{
    private readonly List<Pet> pets = new();
    private readonly IPetRepository _petRepository;

    public PetService(IPetRepository petRepository)
    {
        _petRepository = petRepository;
    }

    public async Task<Pet> Add(Pet pet)
    {
        return await _petRepository.AddAsync(pet);
    }

    public List<Pet> GetAllPets()
    {
        return pets;
    }

    public Pet? GetById(int id)
    {
        return pets.FirstOrDefault(p => p.Id == id);
    }

    public Pet? Update(int id, Pet petAtualizado)
    {
        var existente = GetById(id);
        if (existente == null)
            return null;

        existente.Nome = petAtualizado.Nome;
        existente.TutorId = petAtualizado.TutorId;
        return existente;
    }

    public bool Delete(int id)
    {
        var pet = GetById(id);
        return pet != null && pets.Remove(pet);
    }
    
}