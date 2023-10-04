using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Data.configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            //Aqui se configuran las propiedades de la entidad Marca.
            //Usando objeto builder
            builder.ToTable("Pais");//ToTable es para indicar el nombre de la tabla

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p => p.NombrePais)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}