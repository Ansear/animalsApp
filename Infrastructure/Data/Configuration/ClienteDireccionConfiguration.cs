using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ClienteDireccionConfiguration : IEntityTypeConfiguration<ClienteDireccion>
{
    public void Configure(EntityTypeBuilder<ClienteDireccion> builder)
    {
        builder.ToTable("ClienteDireccion");

        builder.HasKey(cd => cd.Id);
        builder.Property(cd => cd.Id);

        builder.Property(cd => cd.TipoDeVia);

        builder.Property(cd => cd.NumeroPri);

        builder.Property(cd => cd.Letra);

        builder.Property(cd => cd.Bis).HasMaxLength(3);

        builder.Property(cd => cd.LetraSec).HasMaxLength(2);

        builder.Property(cd => cd.Cardinal).HasMaxLength(10);

        builder.Property(cd =>cd.NumeroSec).HasColumnType("int");

        builder.Property(cd => cd.LetraTer).HasMaxLength(10);

        builder.Property(cd => cd.NumeroTer).HasColumnType("int");

        builder.Property(cd => cd.CardinalSec).HasMaxLength(10);

        builder.Property(cd => cd.Complemento).HasMaxLength(50);

        builder.Property(cd => cd.CodigoPostal).HasMaxLength(10);

        builder.HasOne(cd => cd.Clientes).WithOne(c => c.ClienteDireccion).HasForeignKey<ClienteDireccion>(cd => cd.IdCliente);

        builder.HasOne(cd => cd.Ciudades).WithOne(city => city.ClienteDireccion).HasForeignKey<ClienteDireccion>(cd => cd.IdCiudad);
    }
}