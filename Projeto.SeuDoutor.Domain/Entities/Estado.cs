using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Estado : Entity
    {
        private string sigla;
        private string nome;
        private readonly ICollection<Municipio> municipios;

        public Estado()
        {
            this.municipios = new HashSet<Municipio>();
        }

        public string Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public IEnumerable<Municipio> Municipios
        {
            get { return municipios; }
        }
    }
}
