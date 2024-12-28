using Cafe.API.Service;
using Cafe.API.Items;
using Cafe.API.Data;

namespace Cafe.API.Repo;

public class SyrupRepo : ISyrupRepo
{


    private readonly CafeContext _CafeContext;

    public SyrupRepo(CafeContext cafeContext) => _CafeContext = cafeContext;


    public Syrup CreateNewSyrup(Syrup syrup)
    {
       _CafeContext.Syrups?.Add(syrup);
       _CafeContext.SaveChanges();
       return syrup;
    }
    public IEnumerable<Syrup> GetAllSyrups()
    {
        var syrups = _CafeContext.Syrups;
        return syrups!;
    }

    public IEnumerable<Syrup> GetSyrupsByDrink(int id)
    {
        var syrups = _CafeContext.Syrups?.Where(s => s.ItemId == id);
        return syrups!;
    }

    public Syrup? GetSyrupById(int id)
    {
        var syrup = _CafeContext.Syrups?.Find(id);
        return syrup!;
    }

}