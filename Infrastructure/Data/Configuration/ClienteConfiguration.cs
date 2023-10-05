using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Cliente");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id);

        builder.Property(c => c.Nombre).IsRequired().HasMaxLength(50);

        builder.Property(c => c.Apellidos).IsRequired().HasMaxLength(50);

        builder.Property(c => c.Email).IsRequired().HasMaxLength(80);
    }
}