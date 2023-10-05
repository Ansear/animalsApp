using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class RazaConfiguration : IEntityTypeConfiguration<Raza>
{
    public void Configure(EntityTypeBuilder<Raza> builder)
    {
        builder.ToTable("Raza");

        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id);

        builder.Property(r => r.NombreRaza).IsRequired().HasMaxLength(50);
    }
}