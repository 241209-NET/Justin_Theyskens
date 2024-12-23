using Cafe.API.Items;

namespace Cafe.API.Service;

public class SyrupService : ISyrupService
{
    public Syrup GetNewSyrup(Syrup syrup)
    {
        // TODO
        return syrup;
    }

    public Syrup GetSyrupById(int syrupID)
    {
        // TODO
        return new Syrup(Syrup.SyrupFlavor.Vanilla, 1);
    }

    public IEnumerable<Syrup> GetAllSyrups()
    {
        // TODO
        List<Syrup> list = [];
        return list;

    }
    
    public IEnumerable<Syrup> GetSyrupsByDrink(int itemID)
    {
        // TODO
        throw new NotImplementedException();
    }

    //private readonly ISyrupRepo;
}