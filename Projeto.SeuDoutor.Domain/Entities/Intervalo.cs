using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Intervalo : Entity
    {
        private DateTime horaInicio;
        private DateTime horaFim;

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
    }
}
