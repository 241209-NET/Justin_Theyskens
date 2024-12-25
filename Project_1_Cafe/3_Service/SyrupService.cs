using Cafe.API.Repo;
using Cafe.API.Items;

namespace Cafe.API.Service;

public class SyrupService : ISyrupService
{

    private readonly ISyrupRepo _SyrupRepository;

    public SyrupService(ISyrupRepo SyrupRepository) => _SyrupRepository = SyrupRepository;

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
        return _SyrupRepository.GetAllSyrups();
    }

    public IEnumerable<Syrup> GetSyrupsByDrink(int itemID)
    {
        // TODO
        throw new NotImplementedException();        
    }
}