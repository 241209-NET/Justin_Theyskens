using Cafe.API.Items;

namespace Cafe.API.Repo;

public interface ISyrupRepo
{
    Syrup GetNewSyrup(Syrup syrup);
    IEnumerable<Syrup> GetAllSyrups();
    IEnumerable<Syrup> GetSyrupsByDrink();

    Syrup? GetSyrup(int itemID, int index);
}