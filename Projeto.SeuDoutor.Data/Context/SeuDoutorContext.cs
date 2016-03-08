using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using Projeto.SeuDoutor.Data.EntityConfig;
using System.Data.Entity;
using Projeto.SeuDoutor.Domain.Entities;

namespace Projeto.SeuDoutor.Data.Context
{
    public class SeuDoutorContext : DbContext
    {
        public SeuDoutorContext()
            :base("DoutorContexto")
        {
           
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<PerfilMedico> PerfilMedico { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Convenio> Convenio { get; set; }
        public DbSet<ConfiguracaoHorario> ConfiguracaoHorario { get; set; }
        public DbSet<Conselho> Conselho { get; set; }
        public DbSet<Consultorio> Consultorio { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Foto> Foto { get; set; }
        public DbSet<Intervalo> Intervalo { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Pergunta> Pergunta { get; set; }
        public DbSet<Questionario> Questionario { get; set; }
        public DbSet<RespostaQuestionario> RespostaQuestionario { get; set; }
        public DbSet<RespostaQuestionarioAvaliado> RespostaQuestionarioAvaliado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new PerfilMedicoConfiguration());
            modelBuilder.Configurations.Add(new ConsultaConfiguration());
            modelBuilder.Configurations.Add(new ConvenioConfiguration());
            modelBuilder.Configurations.Add(new ConfiguracaoHorarioConfiguration());
            modelBuilder.Configurations.Add(new ConselhoConfiguration());
            modelBuilder.Configurations.Add(new ConsultorioConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new EspecialidadeConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new FotoConfiguration());
            modelBuilder.Configurations.Add(new IntervaloConfiguration());
            modelBuilder.Configurations.Add(new MunicipioConfiguration());
            modelBuilder.Configurations.Add(new PerguntaConfiguration());
            modelBuilder.Configurations.Add(new QuestionarioConfiguration());
            modelBuilder.Configurations.Add(new RespostaQuestionarioConfiguration());
            modelBuilder.Configurations.Add(new RespostaQuestionarioAvaliadoConfiguration());
        }
    }
}
