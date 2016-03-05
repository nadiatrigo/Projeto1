using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class AvaliacaoConfiguration : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoConfiguration()
        {
            HasKey(a => a.Id);

            HasOptional(p => p.PerfilMedico)
                .WithMany(a => a.Avaliacoes)
                .HasForeignKey(p => p.PerfilMedicoID)
                .WillCascadeOnDelete(false);
        }
    }
}
