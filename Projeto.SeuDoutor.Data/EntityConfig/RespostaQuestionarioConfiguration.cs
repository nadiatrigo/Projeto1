using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class RespostaQuestionarioConfiguration : EntityTypeConfiguration<RespostaQuestionario>
    {
        public RespostaQuestionarioConfiguration()
        {
            HasKey(rq => rq.Id);

            Property(rq => rq.Nota);

            //relationship  1:*
            HasRequired(u => u.Usuario)
                .WithMany(rq => rq.RespostasQuestionario)
                .HasForeignKey(u => u.UsuarioId)
                .WillCascadeOnDelete(false);
        }
    }
}
