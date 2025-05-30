public interface IPetService
{
    List<Pet> GetAllPets();

    Pet? GetById(int Id);

    Task <Pet> Add(Pet pet);

    Pet? Update(int id, Pet pet);

    bool Delete(int id);
    
}