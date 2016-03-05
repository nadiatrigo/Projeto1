using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class ConsultorioConfiguration : EntityTypeConfiguration<Consultorio>
    {
        public ConsultorioConfiguration()
        {
            HasKey(c => c.Id);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(150);

            Property(c => c.Telefone01)
                .HasColumnType("varchar")
                .HasMaxLength(11);

            Property(c => c.Telefone02)
                .HasColumnType("varchar")
                .HasMaxLength(11);

            Property(c => c.DuracaoConsulta);

            //relationship  1:*
            HasRequired(p => p.PerfilMedico)
                .WithMany(c => c.Consultorios)
                .HasForeignKey(p => p.PerfilMedicoId)
                .WillCascadeOnDelete(false);

            //relationship 1:1
            HasRequired(c => c.ConfiguracaoHorario)
                .WithMany()
                .HasForeignKey(c => c.ConfiguracaoHorarioId);
        }
    }
}
