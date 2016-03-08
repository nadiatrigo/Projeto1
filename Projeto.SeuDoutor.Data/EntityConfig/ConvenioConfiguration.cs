using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class ConvenioConfiguration : EntityTypeConfiguration<Convenio>
    {
        public ConvenioConfiguration()
        {
            HasKey(c => c.Id);

            //relationship  1:*
            HasRequired(c => c.Consultorio)
                .WithMany(co => co.Convenios)
                .HasForeignKey(c => c.ConsultorioId)
                .WillCascadeOnDelete(false);
        }
    }
}
