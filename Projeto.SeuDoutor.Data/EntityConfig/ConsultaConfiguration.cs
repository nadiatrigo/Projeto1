﻿using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class ConsultaConfiguration : EntityTypeConfiguration<Consulta>
    {
        public ConsultaConfiguration()
        {
            HasKey(c => c.Id);

            //relationship  1:*
            HasRequired(u => u.Usuario)
                .WithMany(c => c.Consultas)
                .HasForeignKey(u => u.UsuarioId)
                .WillCascadeOnDelete(false);                   
        }
    }
}
