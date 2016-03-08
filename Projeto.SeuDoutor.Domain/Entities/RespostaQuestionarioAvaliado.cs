using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class RespostaQuestionarioAvaliado : Entity
    {
        public virtual PerfilMedico PerfilMedico { get; set; }
        public virtual Consultorio Consultorio { get; set; }
        public virtual RespostaQuestionario RespostaQuestionario { get; set; }

        //FK 
        public int? PerfilMedicoId { get; set; }
        public int? ConsultorioId { get; set; }
        public int RespostaQuestionarioId { get; set; }

        public RespostaQuestionarioAvaliado()
        {

        }
    }
}
