﻿using Projeto.SeuDoutor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.EntityConfig
{
    public class EspecialidadeConfiguration : EntityTypeConfiguration<Especialidade>
    {
        public EspecialidadeConfiguration()
        {
            HasKey(e => e.Id);

            //relationship  1:*
            HasRequired(e => e.PerfilMedico)
                .WithMany(p => p.Especialidades)
                .HasForeignKey(e => e.PerfilMedicoID)
                .WillCascadeOnDelete(false);
        }
    }
}
