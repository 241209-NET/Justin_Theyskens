using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;

namespace Cafe.API.Repo;

public class SyrupRepo : ISyrupRepo
{


    private readonly SyrupContext _SyrupContext;

    public SyrupRepo(SyrupContext SyrupContext) => _SyrupContext = SyrupContext;


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
        throw new NotImplementedException();
    }

}