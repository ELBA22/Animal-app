using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration
{
    public class ClienteDireccionConfiguration : IEntityTypeConfiguration<ClienteDireccion>
    {
        public void Configure(EntityTypeBuilder<ClienteDireccion> builder)
        {
            builder.ToTable("ClienteDireccion");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.TipoDeVia)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.NumeroPri)
            .HasColumnType("int");

            builder.Property(p => p.Letra)
            .IsRequired()
            .HasMaxLength(1);

            builder.Property(p => p.Bis)
            .IsRequired()
            .HasMaxLength(3);

            builder.Property(p => p.LetraSec)
            .IsRequired()
            .HasMaxLength(2);

            builder.Property(p => p.Cardinal)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.NumeroSec)
            .HasColumnType("int");

            builder.Property(p => p.LetraTer)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.NumeroTer)
            .HasColumnType("int");

            builder.Property(p => p.CardinalSec)
            .IsRequired()
            .HasMaxLength(10);

            builder.Property(p => p.Complemento)
            .HasMaxLength(50);

            builder.Property(p => p.CodigoPostal)
            .HasMaxLength(10);

            builder.HasOne(f => f.Clientes)
            .WithOne(f => f.ClientesDirecciones)
            .HasForeignKey<ClienteDireccion>(b => b.IdClienteFk);

            builder.HasOne(f => f.Ciudades)
            .WithMany(f => f.ClientesDirecciones)
            .HasForeignKey(f => f.IdCiudadFk);
            
        }
        
    }
}