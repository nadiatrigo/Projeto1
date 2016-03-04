using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Foto : Entity
    {
        private Guid nomeArquivo;
        private Consultorio consultorio;

        public Guid NomeArquivo
        {
            get { return nomeArquivo; }
            set { nomeArquivo = value; }
        }

        public Consultorio Consultorio
        {
            get { return consultorio; }
            set { consultorio = value; }
        }
    }
}
