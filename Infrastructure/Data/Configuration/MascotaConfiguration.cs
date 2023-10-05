using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class MascotaConfiguration : IEntityTypeConfiguration<Mascota>
{
    public void Configure(EntityTypeBuilder<Mascota> builder)
    {
        builder.ToTable("Mascota");

        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id);

        builder.Property(m => m.Nombre).IsRequired().HasMaxLength(50);

        builder.Property(m => m.Especie).IsRequired();

        builder.Property(m => m.FechaNacimiento).IsRequired().HasColumnType("date");

        builder.HasOne(m => m.Raza).WithMany(r => r.Mascotas).HasForeignKey(m => m.IdRaza).IsRequired();

        builder.HasOne(m => m.Clientes).WithMany(c => c.Mascotas).HasForeignKey(m => m.IdCliente).IsRequired();
    }
}