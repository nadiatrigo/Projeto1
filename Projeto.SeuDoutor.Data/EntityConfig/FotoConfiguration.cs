using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class FotoConfiguration : EntityTypeConfiguration<Foto>
    {
        public FotoConfiguration()
        {
            HasKey(f => f.Id);

            //relationship  1:*
            HasRequired(c => c.Consultorio)
                .WithMany(f => f.Fotos)
                .HasForeignKey(c => c.ConsultorioId)
                .WillCascadeOnDelete(false);
        }
    }
}
