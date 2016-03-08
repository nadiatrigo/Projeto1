using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.SeuDoutor.Domain.Interfaces
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTudo();
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
