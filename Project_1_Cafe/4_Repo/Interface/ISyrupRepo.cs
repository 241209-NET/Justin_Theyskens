using Cafe.API.Items;

namespace Cafe.API.Repo;

public interface ISyrupRepo
{
    Syrup CreateNewSyrup(Syrup syrup);
    IEnumerable<Syrup> GetAllSyrups();
    IEnumerable<Syrup> GetSyrupsByDrink(int id);

    Syrup? GetSyrupById(int id);
}