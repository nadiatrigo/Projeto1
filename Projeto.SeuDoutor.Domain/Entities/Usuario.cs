using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Bloqueado { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimoAcesso { get; set; }
        public DateTime? DataBloqueio { get; set; }
        public bool Ativo { get; set; }
        public Sexo Sexo { get; set; }
        public string Foto { get; set; }
        public bool Medico { get; set; }
        public string Telefone { get; set; }

        // Foreign key 
        public int ConvenioID { get; set; }
        public int? PerfilMedicoID { get; set; }

        // Navegation
        public Convenio Convenio { get; set; }                        
        public PerfilMedico PerfilMedico { get; set; }
        public ICollection<Consulta> Consultas { get; set; }

        public Usuario()
        {
            this.Bloqueado = false;
            this.DataCriacao = DateTime.Now;
            this.Ativo = false;
            this.Medico = false;
            this.Consultas = new HashSet<Consulta>();
        }
    }
}
