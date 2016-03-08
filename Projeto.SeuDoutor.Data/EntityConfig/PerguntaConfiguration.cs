using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class PerguntaConfiguration : EntityTypeConfiguration<Pergunta>
    {
        public PerguntaConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(250);
        }
    }
}
