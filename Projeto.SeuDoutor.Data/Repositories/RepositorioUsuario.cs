using Projeto.SeuDoutor.Domain.Entities;
using Projeto.SeuDoutor.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Data.Repositories
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
    }
}
