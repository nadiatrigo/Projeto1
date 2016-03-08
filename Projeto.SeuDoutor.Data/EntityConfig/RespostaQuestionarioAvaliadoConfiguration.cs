using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class RespostaQuestionarioAvaliadoConfiguration : EntityTypeConfiguration<RespostaQuestionarioAvaliado>
    {
        public RespostaQuestionarioAvaliadoConfiguration()
        {
            HasKey(rqa => rqa.Id);

            HasOptional(rqa => rqa.PerfilMedico)
                .WithMany()
                .HasForeignKey(rqa => rqa.PerfilMedicoId);

            HasOptional(rqa => rqa.Consultorio)
                .WithMany()
                .HasForeignKey(rqa => rqa.ConsultorioId);

            HasRequired(rqa => rqa.RespostaQuestionario)
                .WithMany()
                .HasForeignKey(rqa => rqa.RespostaQuestionarioId);
        }
    }
}
