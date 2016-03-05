using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Convenio : Entity
    {
        private string nome;

        // FK
        private int usuarioID;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int UsuarioID
        {
            get { return usuarioID; }
            set { usuarioID = value; }
        }
    }
}
