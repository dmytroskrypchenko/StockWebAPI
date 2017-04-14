namespace Stock.DAL.Repositories.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        TEntity GetById(int id);

        void Insert(TEntity entity);

        void Delete(TEntity entity);

        void DeleteById(int id);

        void Update(TEntity entity);
    }
}
