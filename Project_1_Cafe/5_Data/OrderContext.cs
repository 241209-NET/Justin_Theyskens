using Microsoft.EntityFrameworkCore;
namespace Cafe.API.Data;

public class OrderContext :DbContext
{
    public OrderContext() {}

    public OrderContext(DbContextOptions<OrderContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders {get; set; }
}