using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace Infrastructure.Data.Configuration;
public class ServicioConfiguration : IEntityTypeConfiguration<Servicio>
{
    public void Configure(EntityTypeBuilder<Servicio> builder)
    {
        builder.ToTable("Servicio");

        builder.HasKey(s => s.Id);
        builder.Property(s => s.Id);

        builder.Property(s => s.Nombre).IsRequired();

        builder.Property(s => s.Precio).IsRequired();
    }
}