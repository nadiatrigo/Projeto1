using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class ConfiguracaoHorario : Entity
    {
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public virtual ICollection<Intervalo> Intervalos { get; set; }
        public virtual Consultorio Consultorio { get; set; }

        // FK
        public int? ConsultorioId { get; set; }

        public ConfiguracaoHorario()
        {
            this.Intervalos = new HashSet<Intervalo>();
        }

    }
}
