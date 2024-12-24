using Microsoft.EntityFrameworkCore;
namespace Cafe.API.Data;

public class DrinkContext :DbContext
{
    public DrinkContext() {}

    public DrinkContext(DbContextOptions<DrinkContext> options)
        : base(options)
    {
    }

}