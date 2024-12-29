using Cafe.API.Items;

namespace Cafe.API.Service;

public interface ISyrupService
{
    Syrup CreateNewSyrup(Syrup syrup);
    Syrup GetSyrupById(int syrupID);
    IEnumerable<Syrup> GetAllSyrups();
    IEnumerable<Syrup> GetSyrupsByDrink(int itemID);
    
}