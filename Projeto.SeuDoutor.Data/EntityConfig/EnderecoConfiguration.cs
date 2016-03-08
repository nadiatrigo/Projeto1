using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.Id);

            Property(e => e.Bairro)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            Property(e => e.Cep)
                .HasColumnType("varchar")
                .HasMaxLength(7);

            Property(e => e.Complemento)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(e => e.Latitude);

            Property(e => e.Longitude);

            Property(e => e.Numero);

            //relationship 1:1
            HasRequired(e => e.Estado)
                .WithMany()
                .HasForeignKey(e => e.EstadoId);

            //relationship 1:1
            HasRequired(e => e.Municipio)
                .WithMany()
                .HasForeignKey(e => e.MunicipioId);
        }
    }
}
