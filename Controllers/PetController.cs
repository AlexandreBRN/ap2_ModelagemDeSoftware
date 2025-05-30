using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PetController : ControllerBase
{
    private IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }


    [HttpGet]
    public ActionResult<List<Pet>> GetAll()
    {
        List<Pet> pets = _petService.GetAllPets();
        return Ok(pets);
    }

    [HttpGet("{id}")]
    public ActionResult<Pet> GetById(int id)
    {
        Pet pet = _petService.GetById(id);
        if (pet == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(pet);
        }
    }

    [HttpPost]
    public async Task<ActionResult<Pet>> Post(Pet pet)
    {
        return Ok( await _petService.Add(pet));
    }

    [HttpPut("{id}")]
    public ActionResult Uptade(int id, Pet petAtualizado)
    {
        var atualizado = _petService.Update(id, petAtualizado);
        return atualizado is null ? NotFound() : NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        return _petService.Delete(id) ? NoContent() : NotFound();
    }


}