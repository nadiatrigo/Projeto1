﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Consulta : Entity
    {
        public DateTime DataMarcada { get; set; }     
        public virtual Consultorio Consultorio { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Questionario Questionario { get; set; }

        //FK
        public int? UsuarioId { get; set; }
        public int ConsultorioId { get; set; }
        public int? QuestionarioId { get; set; }        

        public Consulta()
        {

        }
    }
}
