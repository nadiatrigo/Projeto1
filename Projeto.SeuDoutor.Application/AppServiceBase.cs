using Projeto.SeuDoutor.Application.Interface;
using Projeto.SeuDoutor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            this.serviceBase = serviceBase;
        }

        public void Adicionar(TEntity obj)
        {
            serviceBase.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            serviceBase.Atualizar(obj);
        }

        public void Dispose()
        {
            serviceBase.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return serviceBase.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTudo()
        {
            return serviceBase.ObterTudo();
        }

        public void Remover(TEntity obj)
        {
            serviceBase.Remover(obj);
        }
    }
}
