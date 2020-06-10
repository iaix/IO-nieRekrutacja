using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        Task SaveAsync();
        void Rollback();
    }

    public interface IUnitOfWorkFactory
    {
        IUnitOfWork CreateUnitOfWork();
        IUnitOfWork CreateUnitOfWork(bool beginDatabaseTransaction);
    }


}
