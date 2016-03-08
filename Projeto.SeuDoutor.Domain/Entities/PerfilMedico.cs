using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class PerfilMedico : Entity
    {
        public int NumeroRegistro { get; set; }
        public virtual Estado EstadoRegistro { get; set; }
        public virtual Conselho Conselho { get; set; }
        //public virtual Agenda Agenda { get; set; }
        //private Plano plano;

        // FK
        public int EstadoRegistroId { get; set; }
        public int ConselhoId { get; set; }
        public int AgendaId { get; set; }

        // Navegation
        public virtual ICollection<Especialidade> Especialidades { get; set; }
        public virtual ICollection<Consultorio> Consultorios { get; set; }        

        public PerfilMedico()
        {
            this.Especialidades = new HashSet<Especialidade>();
            this.Consultorios = new HashSet<Consultorio>();
        }

    }
}
