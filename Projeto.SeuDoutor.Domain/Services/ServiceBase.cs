

using Projeto.SeuDoutor.Domain.Interfaces.Repositories;
using Projeto.SeuDoutor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> repositorioBase;

        public ServiceBase(IRepositorioBase<TEntity> repositorioBase)
        {
            this.repositorioBase = repositorioBase;
        }

        public void Adicionar(TEntity obj)
        {
            repositorioBase.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            repositorioBase.Atualizar(obj);
        }

        public void Dispose()
        {
            repositorioBase.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return repositorioBase.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTudo()
        {
            return repositorioBase.ObterTudo();
        }

        public void Remover(TEntity obj)
        {
            repositorioBase.Remover(obj);
        }
    }
}
