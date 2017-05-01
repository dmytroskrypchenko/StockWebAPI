namespace Stock.BL.Services.Abstract
{
    using System.Collections.Generic;

    public interface IBaseService<TEntity, TEntityDto>
       where TEntity : class
       where TEntityDto : class
    {
        TEntityDto GetById(int id);

        void Insert(TEntityDto entity);

        void Insert(IEnumerable<TEntityDto> entities);

        void Delete(TEntityDto entity);

        void DeleteById(int id);

        void Update(TEntityDto entity);

        IEnumerable<TEntityDto> GetAll();
    }
}
