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
        
        //private Convenio convenio;

        public int? PerfilMedicoID { get; set; }
        public virtual PerfilMedico PerfilMedico { get; set; }

        public virtual ICollection<Consulta> Consultas { get; set; }

        public Usuario()
        {
            this.Bloqueado = false;
            this.DataCriacao = DateTime.Now;
            this.Ativo = false;
            this.Medico = false;
            this.Consultas = new HashSet<Consulta>();
        }

        //public string Nome
        //{
        //    get { return nome; }
        //    set { nome = value; }
        //}

        //public DateTime DataNascimento
        //{
        //    get { return dataNascimento; }
        //    set { dataNascimento = value; }
        //}

        //public string Email
        //{
        //    get { return email; }
        //    set { email = value; }
        //}

        //public string Senha
        //{
        //    get { return senha; }
        //    set { senha = value; }
        //}

        //public bool Bloqueado
        //{
        //    get { return bloqueado; }
        //    set { bloqueado = value; }
        //}

        //public DateTime DataCriacao
        //{
        //    get { return dataCriacao; }
        //    set { dataCriacao = value; }
        //}

        //public DateTime UltimoAcesso
        //{
        //    get { return ultimoAcesso; }
        //    set { ultimoAcesso = value; }
        //}

        //public DateTime? DataBloqueio
        //{
        //    get { return dataBloqueio; }
        //    set { dataBloqueio = value; }
        //}

        //public bool Ativo
        //{
        //    get { return ativo; }
        //    set { ativo = value; }
        //}

        //public Sexo Sexo
        //{
        //    get { return sexo; }
        //    set { sexo = value; }
        //}

        //public string Foto
        //{
        //    get { return foto; }
        //    set { foto = value; }
        //}

        //public virtual PerfilMedico PerfilMedico
        //{
        //    get { return perfilMedico; }
        //    set { perfilMedico = value; }
        //}

        //public bool Medico
        //{
        //    get { return medico; }
        //    set { medico = value; }
        //}

        //public string Telefone
        //{
        //    get { return telefone; }
        //    set { telefone = value; }
        //}

        //public IEnumerable<Consulta> Consultas
        //{
        //    get { return consultas; }
        //}

        //public Convenio Convenio
        //{
        //    get { return convenio; }
        //    set { convenio = value; }
        //}
    }
}
