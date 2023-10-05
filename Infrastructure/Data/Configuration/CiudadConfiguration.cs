using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        builder.ToTable("Ciudad");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id);

        builder.Property(c => c.NombreCiudad).IsRequired().HasMaxLength(50);

        builder.HasOne(c => c.Departamentos).WithMany(c => c.Ciudades).HasForeignKey(c => c.IdDep);
    }
}