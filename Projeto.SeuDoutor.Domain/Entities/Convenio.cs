using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Convenio : Entity
    {
        public string Nome { get; set; }

        // FK
        public int UsuarioId { get; set; }
        public int ConsultorioId { get; set; }
        public virtual Consultorio Consultorio { get; set; }

        public Convenio()
        {

        }
    }
}
