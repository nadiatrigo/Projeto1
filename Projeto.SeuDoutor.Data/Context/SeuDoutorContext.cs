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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new PerfilMedicoConfiguration());
            modelBuilder.Configurations.Add(new ConsultaConfiguration());
            modelBuilder.Configurations.Add(new ConvenioConfiguration());
        }
    }
}
