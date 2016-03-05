using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class PerfilMedicoConfiguration : EntityTypeConfiguration<PerfilMedico>
    {
        public PerfilMedicoConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.NumeroRegistro)
                .IsRequired();

            //relationship  1:1
            HasOptional(u => u.EstadoRegistro)
                .WithMany()
                .HasForeignKey(p => p.EstadoRegistroId);

            //relationship  1:1
            HasOptional(u => u.Conselho)
                .WithMany()
                .HasForeignKey(p => p.ConselhoId);

            //relationship  1:1
            HasOptional(u => u.Agenda)
                .WithMany()
                .HasForeignKey(p => p.AgendaId);
        }
    }
}
