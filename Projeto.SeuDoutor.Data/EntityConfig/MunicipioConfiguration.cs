using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class MunicipioConfiguration : EntityTypeConfiguration<Municipio>
    {
        public MunicipioConfiguration()
        {
            HasKey(m => m.Id);

            Property(m => m.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100);            

            //relationship  1:*
            HasRequired(m => m.Estado)
                .WithMany(e => e.Municipios)
                .HasForeignKey(m => m.EstadoId)
                .WillCascadeOnDelete(false);
        }
    }
}
