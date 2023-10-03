using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class AnimalsContext : DbContext
{
    public AnimalsContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}