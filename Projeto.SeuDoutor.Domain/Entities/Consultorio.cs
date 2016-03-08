using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Consultorio : Entity
    {                
        public string Nome { get; set; }        
        public string Telefone01 { get; set; }
        public string Telefone02 { get; set; }
        public DateTime DuracaoConsulta { get; set; }

        // FK
        public int PerfilMedicoId { get; set; }        
        public int EnderecoId { get; set; }
        public int ConfiguracaoHorarioId { get; set; }

        public virtual PerfilMedico PerfilMedico { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ConfiguracaoHorario ConfiguracaoHorario { get; set; }        
        public virtual ICollection<Foto> Fotos { get; set; }
        public virtual ICollection<Convenio> Convenios { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }


        public Consultorio()
        {
            this.Fotos = new HashSet<Foto>();
            this.Convenios = new HashSet<Convenio>();
            this.Consultas = new HashSet<Consulta>();
        }
    }
}
