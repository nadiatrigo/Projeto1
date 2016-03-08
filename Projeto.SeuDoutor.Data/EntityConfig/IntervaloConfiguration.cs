using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class IntervaloConfiguration : EntityTypeConfiguration<Intervalo>
    {
        public IntervaloConfiguration()
        {
            HasKey(i => i.Id);

            Property(i => i.HoraInicio);

            Property(i => i.HoraFim);

            //relationship  1:*
            HasRequired(ch => ch.ConfiguracaoHorario)
                .WithMany(i => i.Intervalos)
                .HasForeignKey(ch => ch.ConfiguracaoHorarioId)
                .WillCascadeOnDelete(false);
        }
    }
}
