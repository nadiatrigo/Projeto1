using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Estado : Entity
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Municipio> Municipios { get; set; }

        public Estado()
        {
            this.Municipios = new HashSet<Municipio>();
        }

    }
}
