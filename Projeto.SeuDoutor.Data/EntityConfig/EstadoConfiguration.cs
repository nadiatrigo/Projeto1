using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class EstadoConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            HasKey(e => e.Id);

            Property(e => e.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(e => e.Sigla)
                .HasColumnType("varchar")
                .HasMaxLength(3);
        }
    }
}
