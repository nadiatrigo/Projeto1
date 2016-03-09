using Projeto.SeuDoutor.Domain.Entities;
using Projeto.SeuDoutor.Domain.Interfaces.Repositories;
using Projeto.SeuDoutor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        private readonly IRepositorioUsuario repositorioUsuario;

        public UsuarioService(IRepositorioUsuario repositorioUsuario)
            : base(repositorioUsuario)
        {
            this.repositorioUsuario = repositorioUsuario;
        }
    }
}
