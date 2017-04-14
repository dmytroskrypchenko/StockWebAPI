namespace Stock.DAL.Infrastructure.Concrete
{
    using System;
    using Abstract;
    using Repositories.Abstract;
    using Repositories.Concrete;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly StockContext _context = new StockContext();

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IBaseRepository<T> Repository<T>() where T : class
        {
            return new BaseRepository<T>(_context);
        }
    }
}
