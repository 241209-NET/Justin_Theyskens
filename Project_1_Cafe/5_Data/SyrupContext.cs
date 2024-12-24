using Microsoft.EntityFrameworkCore;
using Cafe.API.Items;

namespace Cafe.API.Data;

public partial class SyrupContext :DbContext
{
    public SyrupContext() {}

    public SyrupContext(DbContextOptions<SyrupContext> options)
        : base(options)
    {
    }

}
