using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {

            HasKey(u => u.Id);

            Property(u => u.Email)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_Email") { IsUnique = true }));

            Property(u => u.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(150);

            Property(u => u.Foto)
                .HasMaxLength(150);

            Property(u => u.Senha)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);

            Property(u => u.Telefone)
                .HasColumnType("varchar")
                .HasMaxLength(11);

            Property(u => u.DataBloqueio)
                .IsOptional();

            Property(u => u.DataNascimento)
                .IsRequired();

            Property(u => u.DataCriacao)
                .IsRequired();

            Property(u => u.Ativo)
                .IsRequired();

            //relationship  1:1
            HasOptional(u => u.PerfilMedico)
                .WithMany()
                .HasForeignKey(p => p.PerfilMedicoId);

            //relationship  1:1
            HasRequired(u => u.Convenio)
                .WithMany()
                .HasForeignKey(c => c.ConvenioId);

        }
    }
}
