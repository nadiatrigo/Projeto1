using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class ConfiguracaoHorario : Entity
    {
        private DateTime horaInicio;
        private DateTime horaFim;
        private readonly ICollection<Intervalo> intervalos;
        private Consultorio consultorio;

        public ConfiguracaoHorario()
        {
            this.intervalos = new HashSet<Intervalo>();
        }

        public DateTime HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public DateTime HoraFim
        {
            get { return horaFim; }
            set { horaFim = value; }
        }

        public IEnumerable<Intervalo> Intervalos
        {
            get { return intervalos; }
        }

        public Consultorio Consultorio
        {
            get { return consultorio; }
            set { consultorio = value; }
        }
    }
}
