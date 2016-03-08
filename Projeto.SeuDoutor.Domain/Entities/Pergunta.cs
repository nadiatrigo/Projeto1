using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Pergunta : Entity
    {
        public string Descricao { get; set; }
        public virtual ICollection<Questionario> Questionarios { get; set; }

        public Pergunta()
        {
                
        }
    }
}
