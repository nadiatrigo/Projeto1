using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Consulta : Entity
    {
        private DateTime dataMarcada;
        private Usuario usuario;
        private Consultorio consultorio;
        private Especialidade especialidade;

        public Consulta()
        {

        }

        public DateTime DataMarcada
        {
            get { return dataMarcada; }
            set { dataMarcada = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public Consultorio Consultorio
        {
            get { return consultorio; }
            set { consultorio = value; }
        }

        public Especialidade Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }
    }
}
