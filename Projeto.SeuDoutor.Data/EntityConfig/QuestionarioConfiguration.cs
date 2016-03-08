using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class QuestionarioConfiguration : EntityTypeConfiguration<Questionario>
    {
        public QuestionarioConfiguration()
        {
            HasKey(q => q.Id);

            Property(q => q.Descricao)
                .HasColumnType("varchar")
                .HasMaxLength(200);

            HasMany(q => q.Perguntas)
                .WithMany(c => c.Questionarios)
                .Map(mc =>
                {
                    mc.MapLeftKey("QuestionarioId");
                    mc.MapRightKey("PerguntaId");
                    mc.ToTable("QuestionarioPergunta");
                });
        }
    }
}
