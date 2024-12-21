using Cafe.API.Service;
using Cafe.API.Items;

namespace Cafe.API.Repo;

public class SyrupRepo : ISyrupRepo
{

    public Syrup GetNewSyrup(Syrup syrup)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Syrup> GetAllSyrups()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Syrup> GetSyrupsByDrink()
    {
        throw new NotImplementedException();
    }

    public Syrup? GetSyrup(int itemID, int index)
    {

        /* something like this
        var drink? = something.FindById(itemID)
        List<Syrup> list = drink.Syrups;
        var syrup = drink?.Syrups[index];
        return syrup;
        */
        throw new NotImplementedException();
    }

}