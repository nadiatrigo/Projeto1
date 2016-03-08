using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Intervalo : Entity
    {
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public virtual ConfiguracaoHorario ConfiguracaoHorario { get; set; }

        // FK
        public int ConfiguracaoHorarioId { get; set; }

        public Intervalo()
        {

        }
    }
}
