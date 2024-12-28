using Cafe.API.Repo;
using Cafe.API.Items;

namespace Cafe.API.Service;

public class SyrupService : ISyrupService
{

    private readonly ISyrupRepo _SyrupRepository;

    public SyrupService(ISyrupRepo syrupRepository) => _SyrupRepository = syrupRepository;

    public Syrup CreateNewSyrup(Syrup syrup)
    {
        var newSyrup = _SyrupRepository.CreateNewSyrup(syrup);
        return newSyrup;
    }

    public Syrup GetSyrupById(int id)
    {
        var syrup = _SyrupRepository.GetSyrupById(id);
        return syrup!;
    }

    public IEnumerable<Syrup> GetAllSyrups()
    {
        return _SyrupRepository.GetAllSyrups();
    }

    public IEnumerable<Syrup> GetSyrupsByDrink(int itemID)
    {
        var syrups = _SyrupRepository.GetSyrupsByDrink(itemID);
        return syrups;        
    }
}