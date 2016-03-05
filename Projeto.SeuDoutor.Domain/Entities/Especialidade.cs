using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Especialidade : Entity
    {
        public string Nome { get; set; }

        public int PerfilMedicoID { get; set; }
        public virtual PerfilMedico PerfilMedico { get; set; }

        public Especialidade()
        {

        }

    }
}
