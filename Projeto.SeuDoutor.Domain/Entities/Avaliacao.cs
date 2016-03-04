using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Avaliacao : Entity
    {
        private int pontuacao;
        private string comentario;
        private PerfilMedico medico;
        private Consultorio consultorio;
        private Usuario usuario;

        public Avaliacao()
        {

        }

        public int Pontuacao
        {
            get { return pontuacao; }
            set { pontuacao = value; }
        }

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public PerfilMedico Medico
        {
            get { return medico; }
            set { medico = value; }
        }

        public Consultorio Consultorio
        {
            get { return consultorio; }
            set { consultorio = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
