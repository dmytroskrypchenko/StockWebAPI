using System;
using Stock.DAL.Repositories.Abstract;

namespace Stock.DAL.Infrastructure.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        IBaseRepository<T> Repository<T>() where T : class;
    }
}
