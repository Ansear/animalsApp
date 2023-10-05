using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.ToTable("Departamento");

        builder.Property(d => d.Id);
        builder.HasKey(d => d.Id);

        builder.Property(d => d.NombreDep).IsRequired().HasMaxLength(50);

        builder.HasOne(d => d.Paises).WithMany(d => d.Departamentos).HasForeignKey(d => d.IdPais);
        
    }
}