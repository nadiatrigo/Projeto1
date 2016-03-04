using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class Endereco : Entity
    {
        private string bairro;
        private string logradouro;
        private string cep;
        private string complemento;
        private string numero;
        private Estado estado;
        private Municipio municipio;
        private double latitude;
        private double longitude;

        public Endereco()
        {

        }

        public Municipio Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }

        public Estado Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Cep
        {
            get { return cep; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                    cep = value.Replace("-", "");
            }
        }

        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
    }
}
