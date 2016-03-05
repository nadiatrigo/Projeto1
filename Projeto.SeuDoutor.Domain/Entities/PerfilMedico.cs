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
        public Estado EstadoRegistro { get; set; }
        public Conselho Conselho { get; set; }
        public Agenda Agenda { get; set; }
        //private Plano plano;

        // FK
        public int EstadoRegistroId { get; set; }
        public int ConselhoId { get; set; }
        public int AgendaId { get; set; }

        // Navegation
        public virtual ICollection<Especialidade> Especialidades { get; set; }
        public virtual ICollection<Consultorio> Consultorios { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }

        

        public PerfilMedico()
        {
            this.Especialidades = new HashSet<Especialidade>();
            this.Consultorios = new HashSet<Consultorio>();
            this.Avaliacoes = new HashSet<Avaliacao>();
        }

    }
}
