using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Municipio : Entity
    {
        private string nome;
        private Estado estado;

        public virtual string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public virtual Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
