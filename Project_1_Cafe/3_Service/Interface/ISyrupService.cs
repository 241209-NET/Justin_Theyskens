using Cafe.API.Items;

namespace Cafe.API.Service;

public interface ISyrupService
{
    /*
    public interface IPetService
{
    Pet CreateNewPet(Pet newPet);
    IEnumerable<Pet> GetAllPets();
    Pet? GetPetById(int id);
    IEnumerable<Pet> GetPetByName(string name);
}
    */

    Syrup GetNewSyrup(Syrup syrup);
    IEnumerable<Syrup> GetAllSyrups();
    
    IEnumerable<Syrup> GetSyrupByDrink(int itemID);
}