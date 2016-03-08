using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Municipio : Entity
    {
        public string Nome { get; set; }
        public virtual Estado Estado { get; set; }

        // FK
        public int EstadoId { get; set; }

        public Municipio()
        {

        }
    }
}
