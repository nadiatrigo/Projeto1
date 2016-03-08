using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class ConfiguracaoHorarioConfiguration : EntityTypeConfiguration<ConfiguracaoHorario>
    {
        public ConfiguracaoHorarioConfiguration()
        {
            HasKey(ch => ch.Id);

            Property(ch => ch.HoraFim);

            Property(ch => ch.HoraInicio);

            //relationship 1:1
            HasRequired(ch => ch.Consultorio)
                .WithMany()
                .HasForeignKey(ch => ch.ConsultorioId);
        }
    }
}
