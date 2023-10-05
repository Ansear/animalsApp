using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ClienteTelefonoConfiguration : IEntityTypeConfiguration<ClienteTelefono>
    {
        public void Configure(EntityTypeBuilder<ClienteTelefono> builder)
        {
            builder.ToTable("ClienteTelefono");

            builder.HasKey(ct => ct.Id);
            builder.Property(ct => ct.Id);

            builder.Property(ct => ct.Numero).IsRequired().HasMaxLength(50);

            builder.HasOne(ct => ct.Clientes).WithMany(c => c.ClientesTelefonos).HasForeignKey(ct => ct.IdCliente);

        }
    }
}