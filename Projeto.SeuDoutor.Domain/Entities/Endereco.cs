using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Endereco : Entity
    {
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // FK
        public int EstadoId { get; set; }
        public int MunicipioId { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Municipio Municipio { get; set; }

        public Endereco()
        {

        }

    }
}
