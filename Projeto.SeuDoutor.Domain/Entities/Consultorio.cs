using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Consultorio : Entity
    {
        private PerfilMedico perfilMedico;
        private Endereco endereco;
        private string nome;
        private readonly ICollection<Foto> fotos;
        private string telefone01;
        private string telefone02;
        private DateTime duracaoConsulta;
        private readonly ICollection<Convenio> convenios;
        private ConfiguracaoHorario configuracaoHorario;

        public Consultorio()
        {
            this.fotos = new HashSet<Foto>();
            this.convenios = new HashSet<Convenio>();
        }

        public PerfilMedico PerfilMedico
        {
            get { return perfilMedico; }
            set { perfilMedico = value; }
        }

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public virtual string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone01
        {
            get { return telefone01; }
            set { telefone01 = value; }
        }

        public virtual string Telefone02
        {
            get { return telefone02; }
            set { telefone02 = value; }
        }

        public IEnumerable<Foto> Fotos
        {
            get { return fotos; }
        }

        public IEnumerable<Convenio> Convenios
        {
            get { return convenios; }
        }

        public ConfiguracaoHorario ConfiguracaoHorario
        {
            get { return configuracaoHorario; }
            set { configuracaoHorario = value; }
        }
    }
}
