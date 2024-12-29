using Microsoft.EntityFrameworkCore;
using Cafe.API.Items;
namespace Cafe.API.Data;

public class CafeContext :DbContext
{
    public CafeContext() {}

    public CafeContext(DbContextOptions<CafeContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Order>? Orders { get; set; }
    public virtual DbSet<Drink>? Drinks { get; set; }
    public virtual DbSet<Food>? Food { get; set; }
    public virtual DbSet<Syrup>? Syrups { get; set; }
}