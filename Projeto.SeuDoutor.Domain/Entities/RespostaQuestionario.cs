using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class RespostaQuestionario : Entity
    {
        public int Nota { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Questionario Questionario { get; set; }
        public virtual Pergunta Pergunta { get; set; }

        //FK
        public int UsuarioId { get; set; }
        public int QuestionarioId { get; set; }
        public int PerguntaId { get; set; }

        public RespostaQuestionario()
        {

        }

    }
}
