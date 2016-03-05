using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class ConvenioConfiguration : EntityTypeConfiguration<Convenio>
    {
        public ConvenioConfiguration()
        {
            HasKey(c => c.Id);
        }
    }
}
