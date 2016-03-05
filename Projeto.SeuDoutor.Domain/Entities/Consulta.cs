using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Consulta : Entity
    {
        public DateTime DataMarcada { get; set; }     
        public Consultorio Consultorio { get; set; }
        public Especialidade Especialidade { get; set; }

        //FK
        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


        public Consulta()
        {

        }
    }
}
