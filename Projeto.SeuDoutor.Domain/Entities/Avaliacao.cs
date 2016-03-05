using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Avaliacao : Entity
    {
        public int Pontuacao { get; set; }
        public string Comentario { get; set; }

        public int? PerfilMedicoID { get; set; }
        public PerfilMedico PerfilMedico { get; set; }

        public Consultorio Consultorio { get; set; }
        public Usuario Usuario { get; set; }

        public Avaliacao()
        {

        }

    }
}
