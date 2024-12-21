/*
using Microsoft.EntityFrameworkCore;
using PetTracker.API.Model;

namespace PetTracker.API.Data;

public partial class PetContext : DbContext
{
    public PetContext(){}
    public PetContext(DbContextOptions<PetContext> options) : base(options){}

    public virtual DbSet<Pet> Pets { get; set; }
}
*/
using Microsoft.EntityFrameworkCore;
using Cafe.API.Items;

namespace Cafe.API.Data;

public class SyrupContext :DbContext
{
    public SyrupContext() {}

    public SyrupContext(DbContextOptions<SyrupContext> options)
        : base(options)
    {
    }


}
