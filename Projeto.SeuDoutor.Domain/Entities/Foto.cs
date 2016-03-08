using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Foto : Entity
    {
        public Guid NomeArquivo { get; set; }
        public virtual Consultorio Consultorio { get; set; }

        // FK
        public int ConsultorioId { get; set; }

        public Foto()
        {
                
        }
    }
}
