using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Entities
{
    public class PerfilMedico : Entity
    {
        public int NumeroRegistro { get; set; }
        //private readonly ICollection<Especialidade> especialidades;
        //private readonly ICollection<Consultorio> consultorios;
        //private Estado estadoRegistro;
        //private Conselho conselho;
        //private Agenda agenda;
        //private readonly ICollection<Avaliacao> avaliacoes;
        //public virtual Usuario Usuario { get; set; }
        //private Plano plano; 

        public PerfilMedico()
        {
            //this.especialidades = new HashSet<Especialidade>();
            //this.consultorios = new HashSet<Consultorio>();
            //this.avaliacoes = new HashSet<Avaliacao>();
        }

        //public int NumeroRegistro
        //{
        //    get { return numeroRegistro; }
        //    set { numeroRegistro = value; }
        //}

        //public IEnumerable<Especialidade> Especialidades
        //{
        //    get { return especialidades; }
        //}

        //public IEnumerable<Consultorio> Consultorios
        //{
        //    get { return consultorios; }
        //}

        //public Estado EstadoRegistro
        //{
        //    get { return estadoRegistro; }
        //    set { estadoRegistro = value; }
        //}

        //public Conselho Conselho
        //{
        //    get { return conselho; }
        //    set { conselho = value; }
        //}

        //public Agenda Agenda
        //{
        //    get { return agenda; }
        //    set { agenda = value; }
        //}

        //public IEnumerable<Avaliacao> Avaliacoes
        //{
        //    get { return avaliacoes; }
        //}

        //public virtual Usuario Usuario
        //{
        //    get { return usuario; }
        //    set { usuario = value; }
        //}
    }
}
